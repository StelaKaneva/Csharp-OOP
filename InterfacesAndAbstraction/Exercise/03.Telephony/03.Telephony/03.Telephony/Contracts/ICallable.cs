using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony.Contracts
{
    public interface ICallable
    {
        public string Call(string phoneNumber);
    }
}
