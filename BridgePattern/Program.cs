using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Bridge Pattern Demo***");
            Console.WriteLine("\nDealing with a Television:");
            //ElectronicGoods eItem = new Television(presentState);
            ElectronicGoods eItem = new Television();
            IState presentState = new OnState();
            eItem.State = presentState;
            eItem.MoveToCurrentState();
            //Verifying Off state of the Television now
            presentState = new OffState();
            //eItem = new Television(presentState);
            eItem.State = presentState;
            eItem.MoveToCurrentState();
            Console.WriteLine("\n \n Dealing with a VCD:");
            presentState = new OnState();
            //eItem = new VCD(presentState);
            eItem = new VCD();
            eItem.State = presentState;
            eItem.MoveToCurrentState();
            presentState = new OffState();
            //eItem = new VCD(presentState);
            eItem.State = presentState;
            eItem.MoveToCurrentState();
            Console.ReadLine();
        }
    }
}
