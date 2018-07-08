using System;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Visitor Pattern Demo***\n");
            IVisitor visitor = new Visitor();
            MyClass myClass = new MyClass();
            myClass.Accept(visitor);
            Console.ReadLine();
        }
    }
}
