using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ***Chain of Responsibility Pattern Demo * **\n");
            /* Making the chain :IssueRaiser->FaxErrorhandler->EmailErrorHandler*/
            IReceiver faxHandler, emailHandler;
            //End of chain
            emailHandler = new EmailErrorHandler(null);
            //fax handler is placed before email handler
            faxHandler = new FaxErrorHandler(emailHandler);
            //Starting point:IssueRaiser will raise issues and set the first //handler
            IssueRaiser raiser = new IssueRaiser(faxHandler);
            Message m1 = new Message("Fax is reaching late to the destination.", MessagePriority.Normal);
            Message m2 = new Message("Emails are not raching to destinatinations.", MessagePriority.High);
            Message m3 = new Message("In Email, CC field is disabled always.", MessagePriority.Normal);
            Message m4 = new Message("Fax is not reaching destination.",
            MessagePriority.High);
            raiser.RaiseMessage(m1);
            raiser.RaiseMessage(m2);
            raiser.RaiseMessage(m3);
            raiser.RaiseMessage(m4);
            Console.ReadKey();
        }
    }
}
