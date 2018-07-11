using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class CalculatorAdapter
    {
        public double GetArea(Triangle triangle)
        {
            Calculator c = new Calculator();
            Rect rect = new Rect();
            //Area of Triangle=0.5*base*height
            rect.length = triangle.baseT;
            rect.width = 0.5 * triangle.height;
            return c.GetArea(rect);
        }
    }
}
