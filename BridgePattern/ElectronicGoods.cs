using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public abstract class ElectronicGoods
    {
        //Composition - implementor
        protected IState state;
        //Alternative approach to properties:
        //we can also pass an implementor (as input argument) inside a constructor.
        //public ElectronicGoods(IState state)
        //{
        // this.state = state;
        //}
        public IState State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        abstract public void MoveToCurrentState();
    }
}
