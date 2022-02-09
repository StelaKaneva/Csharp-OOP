﻿using _04.WildFarm.Common;
using _04.WildFarm.Models.Animals;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Factories
{
    public class AnimalFactory
    {
        public Animal Create(string type, string name, double weight, string[] args)
        {
            Animal animal;

            if (type == "Hen" || type == "Owl")
            {
                double wingSize = double.Parse(args[0]);

                if (type == "Hen")
                {
                    animal = new Hen(name, weight, wingSize);
                }
                else
                {
                    animal = new Owl(name, weight, wingSize);
                }
            }
            else if (type == "Cat" || type == "Tiger")
            {
                string livingRegion = args[0];
                string breed = args[1];

                if (type == "Cat")
                {
                    animal = new Cat(name, weight, livingRegion, breed);
                }
                else
                {
                    animal = new Tiger(name, weight, livingRegion, breed);
                }
            }
            else if (type == "Mouse" || type == "Dog")
            {
                string livingRegion = args[0];

                if (type == "Mouse")
                {
                    animal = new Mouse(name, weight, livingRegion);
                }
                else
                {
                    animal = new Dog(name, weight, livingRegion);
                }
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.INVALID_TYPE);
            }

            return animal;
        }
    }
}
