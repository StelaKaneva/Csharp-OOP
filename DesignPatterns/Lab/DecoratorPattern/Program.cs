using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPaymentSystem paymentSystem = new PaymentSystemDecorator(new PayPalSystem());

            paymentSystem.LoanMoney("Peter", "George", 2000);
            paymentSystem.PayMoney("Bran", "Stark", 5000);
        }
    }
}
