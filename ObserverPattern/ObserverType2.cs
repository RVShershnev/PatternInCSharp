using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class ObserverType2: IObserver
    {
        string nameOfObserver;
        public ObserverType2(String name)
        {
            this.nameOfObserver = name;
        }
        public void Update(int i)
        {
            Console.WriteLine("{0} notified: myValue in Subject at present: {1}", nameOfObserver, i);
        }
    }
}
