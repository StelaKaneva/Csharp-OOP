using _06.FoodShortage.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _06.FoodShortage.Models
{
    public class Rebel : IAge, IBuyer
    {
        public Rebel(string group, string name, int age)
        {
            Group = group;
            Name = name;
            Age = age;
        }

        public string Group { get;}
        public string Name { get;}
        public int Age { get; }
        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
