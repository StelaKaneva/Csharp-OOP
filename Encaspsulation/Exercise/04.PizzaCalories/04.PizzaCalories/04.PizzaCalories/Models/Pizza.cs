using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories.Models
{
    public class Pizza
    {
        private readonly List<Topping> topings;

        private string name;
        private Dough dough;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
            topings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length > 15 || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }
        public Dough Dough { get; set; }
        
        public void AddTopping(Topping topping)
        {
            if (this.topings.Count < 0 || this.topings.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.topings.Add(topping);
        }

        public override string ToString()
        {
            double sumOfTopingCalories = 0;

            foreach (var item in this.topings)
            {
                sumOfTopingCalories += item.Calories;
            }

            double calories = this.Dough.Calories + sumOfTopingCalories;

            return $"{this.Name} - {calories:f2} Calories.";
        }
    }
}
