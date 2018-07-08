using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public interface IReceiver
    {
        bool HandleMessage(Message message);
    }
}
