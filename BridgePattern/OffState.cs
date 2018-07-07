using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class OffState:IState
    {
        public void MoveState()
        {
            Console.Write("Off State");
        }
    }
}
