using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class ObserverType1: IObserver
    {
        string nameOfObserver;
        public ObserverType1(String name)
        {
            this.nameOfObserver = name;
        }
        public void Update(int i)
        {
            Console.WriteLine("{0} has received an alert: Someone has updated myValue in Subject to: {1}", nameOfObserver,i);
        }
    }
}
