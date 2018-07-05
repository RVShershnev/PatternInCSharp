using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class ConcreteSubject:Subject
    {
        public override void DoSomeWork()
        {
            Console.WriteLine("ConcreteSubject.DoSomeWork()");
        }
    }
}
