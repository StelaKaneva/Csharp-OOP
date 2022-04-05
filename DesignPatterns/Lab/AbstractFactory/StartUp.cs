using AbstractFactory.Contracts;
using AbstractFactory.Factories;
using System;

namespace AbstractFactory
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you an Apple fangirl?");

            var isFangirl = Console.ReadLine() == "yes" ? true : false;

            ITechnologyAbstractFactory techFactory = null;

            if (isFangirl)
            {
                techFactory = new AppleFactory();
            }
            else
            {
                techFactory = new SamsungFactory();
            }

            IMobilePhone myPhone = techFactory.CreatePhone();
            ITablet myTablet = techFactory.CreateTablet();

            Console.WriteLine(myPhone.GetType().Name);
            Console.WriteLine(myTablet.GetType().Name);
        }
    }
}
