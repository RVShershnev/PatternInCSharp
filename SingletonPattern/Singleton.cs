using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private int numberOfInstances = 0;

        private Singleton()
        {
            numberOfInstances++;
        }

        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }

        // Поля 
        public static int MyInt = 25;
        
    }
}
