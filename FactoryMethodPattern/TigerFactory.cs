using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    class TigerFactory: IAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            //Creating a Tiger
            return new Tiger();
        }
    }
}
