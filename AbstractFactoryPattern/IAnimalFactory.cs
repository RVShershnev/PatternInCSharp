using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    interface IAnimalFactory
    {
        IDog GetDog();
        ITiger GetTiger();  
    }
}
