using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class Triangle
    {
        public double baseT;//base
        public double height;//height
        public Triangle(int b, int h)
        {
            this.baseT = b;
            this.height = h;
        }
    }
}
