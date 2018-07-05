using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
        public class SecondChoice : IChoice
        {
            public void MyChoice()
            {
                Console.WriteLine("Traveling to India");
            }
        }
}
