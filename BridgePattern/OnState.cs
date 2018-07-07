using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class OnState:IState
    {
        public void MoveState()
        {
            Console.Write("On State");
        }
    }
}
