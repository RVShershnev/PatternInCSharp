using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    class LargeRobot : IRobot
    {
        public void Print()
        {
            Console.WriteLine("I am a large Robot");
        }
    }
}
