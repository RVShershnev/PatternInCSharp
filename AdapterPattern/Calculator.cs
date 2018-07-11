using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class Calculator
    {
        public double GetArea(Rect rect)
        {
            return rect.length * rect.width;
        }
    }
}
