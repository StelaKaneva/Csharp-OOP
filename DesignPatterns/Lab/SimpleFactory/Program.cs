using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal lion = AnimalFactory.CreateAnimal();

            IAnimal tiger = AnimalFactory.CreateAnimalByType("Tiger");
        }
    }
}
