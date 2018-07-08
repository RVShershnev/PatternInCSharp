using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    class SmallRobot : IRobot
    {
        public void Print()
        {
            Console.WriteLine("This is a small Robot");
        }
    }
}
