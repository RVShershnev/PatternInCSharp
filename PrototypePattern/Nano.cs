using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    class Nano : BasicCar
    {
        public Nano(string m)
        {
            ModelName = m;
        }
        public override BasicCar Clone()
        {
            return (Nano)this.MemberwiseClone();
        }
    }
}
