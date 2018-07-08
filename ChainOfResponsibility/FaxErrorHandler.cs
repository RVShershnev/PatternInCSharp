using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class FaxErrorHandler: IReceiver
    {
        private IReceiver nextReceiver;
        public FaxErrorHandler(IReceiver nextReceiver)
        {
            this.nextReceiver = nextReceiver;
        }
        public bool HandleMessage(Message message)
        {
            if (message.Text.Contains("Fax"))
            {
                Console.WriteLine("FaxErrorHandler processed {0} priority issue: {1}", message.Priority, message.Text);
            return true;
            }
            else
            {
                if (nextReceiver != null)
                    nextReceiver.HandleMessage(message);
            }
            return false;
        }
    }
}
