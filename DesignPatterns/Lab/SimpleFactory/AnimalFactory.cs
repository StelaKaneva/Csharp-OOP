using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class AnimalFactory
    {
        public static IAnimal CreateAnimal()
        {
            //get lion age
            //get lion continent - vsyakakvi proverki mogat da se iznesat tuk
            return new Lion();
        }

        public static IAnimal CreateAnimalByType(string animal)
        {
            if (animal == "Lion")
            {
                return new Lion();
            }
            else if (animal == "Tiger")
            {
                return new Tiger();
            }

            return null;
        }
    }
}
