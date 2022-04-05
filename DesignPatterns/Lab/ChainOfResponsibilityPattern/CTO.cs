using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class CTO : Approver
    {
        public override bool HandleRequest(int amount)
        {
            if (amount < 500)
            {
                Console.WriteLine("Eto vzemi si ot kompaniqta.");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
