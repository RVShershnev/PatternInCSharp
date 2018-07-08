using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    interface IVisitor
    {
        void Visit(MyClass myClassElement);
    }
}
