using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Singleton pattern Demo");           
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;
            Console.WriteLine($"Сингилтон хранит значение в поле MyInt: {Singleton.MyInt}");
            if (s1 == s2)
            {
                Console.WriteLine("Только одна точка входа");
            }
            else
            {
                Console.WriteLine("Разные точки входа");
            }
            Console.Read();
        }
    }
}
