using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class TeamLead : Approver
    {
        public override bool HandleRequest(int amount)
        {
            if (amount < 5)
            {
                Console.WriteLine("Eto ti ot moite lichni.");
                return true;
            }
            else
            {
                return Next.HandleRequest(amount);
            }
        }
    }
}
