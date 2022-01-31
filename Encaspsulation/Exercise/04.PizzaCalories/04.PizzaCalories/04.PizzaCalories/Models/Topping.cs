using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories.Models
{
    public class Topping
    {
        private const double baseCaloriesPerGram = 2;

        private readonly Dictionary<string, double> defaultTypes = new Dictionary<string, double>()
        {
            {"meat", 1.2},
            {"veggies", 0.8},
            {"cheese", 1.1},
            {"sauce", 0.9}
        };

        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                if (!defaultTypes.ContainsKey(value.ToLower()))
                {
                    var valueName = value[0].ToString().ToUpper() + value.Substring(1);
                    throw new ArgumentException($"Cannot place {valueName} on top of your pizza.");
                }

                this.type = value.ToLower();
            }
        }
        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value < 1 || value > 50)
                {
                    var result = this.Type;
                    var correctResult = result[0].ToString().ToUpper() + result.Substring(1);
                    throw new ArgumentException($"{correctResult} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        public double Calories => baseCaloriesPerGram * this.Weight * this.defaultTypes[this.Type];
    }
}
