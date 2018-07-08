using System;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Flyweight Pattern Demo***\n");
            RobotFactory myfactory = new RobotFactory();
            IRobot shape = myfactory.GetRobotFromFactory("Small");
            shape.Print();
            /*Now we are trying to get the 2 more Small robots.
            Note that: now onwards we need not create additional small
            robots because
            we have already created one of this category*/
            for (int i = 0; i < 2; i++)
            {
                shape = myfactory.GetRobotFromFactory("Small");
                shape.Print();
            }
            int NumOfDistinctRobots = myfactory.TotalObjectsCreated;
            Console.WriteLine("\n Now, total numbers of distinct robot objects is = { 0}\n", NumOfDistinctRobots);
            /*Here we are trying to get the 5 more Large robots.
            Note that: now onwards we need not create additional small
            robots because we have already created one of this category */
            for (int i = 0; i < 5; i++)
            {
                shape = myfactory.GetRobotFromFactory("Large");
                shape.Print();
            }
            NumOfDistinctRobots = myfactory.TotalObjectsCreated;
            Console.WriteLine("\n Distinct Robot objects created till now = {0}", NumOfDistinctRobots);
            Console.ReadKey();
        }
    }   
}
