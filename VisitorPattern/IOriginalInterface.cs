using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    interface IOriginalInterface
    {       
        void Accept(IVisitor visitor);
        
}
}
