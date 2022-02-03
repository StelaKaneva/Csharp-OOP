using _06.FoodShortage.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _06.FoodShortage.Models
{
    public class Citizen : IIdentifiable, IBuyer, IBirthable, IAge
    {
        public Citizen(int age, string name, string birthDate, string id)
        {
            Age = age;
            Name = name;
            BirthDate = DateTime.ParseExact(birthDate, "dd/mm/yyyy", null);
            Id = id;
        }

        public int Age { get; }

        public string Name { get;}

        public DateTime BirthDate { get; }

        public string Id { get; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
