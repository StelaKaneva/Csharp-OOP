using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public abstract class Approver
    {
        protected Approver Next { get; set; }
        public abstract bool HandleRequest(int amount);
        public virtual void SetNext(Approver approver)
        {
            Next = approver;
        }
    }
}
