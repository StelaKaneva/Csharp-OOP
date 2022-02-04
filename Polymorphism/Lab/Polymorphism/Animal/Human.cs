using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public class Human
    {
        public Human(Animal pet)
        {
            Pet = pet;
        }

        public Animal Pet { get; set; }

        public void Feed()
        {
            if (Pet is Snake)
            {
                ((Snake)Pet).EatHuman(this);
                (Pet as Snake).EatHuman(this);
            }
            Pet.Eat("Qj");
        }

        public void PutToSleep()
        {
            Pet.Sleep();
        }
    }
}
