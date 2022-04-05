using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class PaymentSystemDecorator : IPaymentSystem
    {
        private IPaymentSystem paymentSystem;

        public PaymentSystemDecorator(IPaymentSystem system)
        {
            paymentSystem = system;
        }

        public void LoanMoney(string from, string to, int amount)
        {
            Console.WriteLine("Decorated payment system and logging loans in our system.");
            paymentSystem.LoanMoney(from, to, amount);
        }

        public void PayMoney(string from, string to, int amount)
        {
            Console.WriteLine("Decorated payment system and logging payments in our system.");
            paymentSystem.PayMoney(from, to, amount);
        }
    }
}
