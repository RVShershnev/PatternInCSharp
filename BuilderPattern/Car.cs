using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    class Car : IBuilder
    {
        private string brandName;
        private Product product;
        public Car(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }

        public void AddHeadLights()
        {
            product.Add("2 Headlights are added");
        }

        public void BuilBody()
        {
            product.Add("This is a body of a Car");
        }

        public void EndOperations()
        {
            //Nothing in this case
        }

        public Product GetVehicle()
        {
            return product;
        }

        public void InsertWheels()
        {
            product.Add("4 wheels are added");
        }

        public void StartUpOperations()
        {
            product.Add(string.Format("Car Model name :{0}", this.brandName));
        }
    }
}
