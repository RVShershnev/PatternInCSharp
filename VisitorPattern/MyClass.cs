using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    class MyClass : IOriginalInterface
    {
        private int myInt = 5;//Initial or default value
        public int MyInt
        {
            get
            {
                return myInt;
            }
            set
            {
                myInt = value;
            }
        }
        public void Accept(IVisitor visitor)
        {
            Console.WriteLine("Initial value of the integer:{0}", myInt);
            visitor.Visit(this);
            Console.WriteLine("\nValue of the integer now:{0}", myInt);
        }
    }
}
