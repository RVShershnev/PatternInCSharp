using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class VCD: ElectronicGoods
    {
        //public VCD(IState state) : base(state)
        //{
        //}
        /*Implementation specific:
        * We are delegating the implementation to the Implementor object*/
        public override void MoveToCurrentState()
        {
            Console.Write("\n VCD is functioning at : ");
            state.MoveState();
        }
    }
}
