using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public abstract class BasicCar
    {
        public string ModelName { set; get; }
        public int Price { set; get; }
        public static int SetPrice()
        {
            int price = 0;
            Random r = new Random();
            int p = r.Next(200000, 400000);
            price =p;
            return price;
        }
        public abstract BasicCar Clone();
    }
}

