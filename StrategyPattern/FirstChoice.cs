using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class FirstChoice : IChoice
    {
        public void MyChoice()
        {
            Console.WriteLine("Traveling to Japan");
        }
    }
}
