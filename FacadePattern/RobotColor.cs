using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class RobotColor
    {
        public void SetDefaultColor()
        {
            Console.WriteLine("This is steel color robot.");
        }
        public void SetGreenColor()
        {
            Console.WriteLine("This is a green color robot.");
        }
    }
}
