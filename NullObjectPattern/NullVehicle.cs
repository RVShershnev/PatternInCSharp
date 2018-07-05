using System;
using System.Collections.Generic;
using System.Text;

namespace NullObjectPattern
{
    class NullVehicle:IVehicle
    {
        private static readonly NullVehicle instance = new NullVehicle();
        public static int nullVehicleCount = 0;
        public static NullVehicle Instance
        {
            get
            {
                //Console.WriteLine("We already have an instance now. Use it.");
            return instance;
            }
        }
        public void Travel()
        {
            //Do Nothing
        }
    }
}
