using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract class IAnimalFactory
    { 
        public abstract IAnimal CreateAnimal();
    }
}

