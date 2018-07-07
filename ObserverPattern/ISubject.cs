using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    interface ISubject
    {
        void Register(IObserver o);
        void Unregister(IObserver o);
        void NotifyRegisteredUsers(int i);
    }
}
