using FactoryMethod.Contracts;
using FactoryMethod.Contracts.Factories;
using System;

namespace FactoryMethod
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which continent do you wanna play?");
            string continent = Console.ReadLine();

            IAnimalFactory factory = new EuropeFactory();

            if (continent == "Africa")
            {
                factory = new AfricaFactory();
            }

            Carnivore animal = factory.GetCarnivore(); //spored tova na koy kontinent se namirame, shte suzdava razlichni jivotni / pravilniq carnivore


        }
    }
}
