using _04.PizzaCalories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.PizzaCalories
{
    public class Engine
    {
        public void Run()
        {
			try
			{
				string[] pizzaTokens = Console.ReadLine().
					Split(" ").ToArray();
				string pizzaName = pizzaTokens[1];

				string[] doughTokens = Console.ReadLine().
					Split(" ").ToArray();
				string doughType = doughTokens[1];
				string doughBakingTechnique = doughTokens[2];
				double doughWeight = double.Parse(doughTokens[3]);

				Dough dough = new Dough(doughType, doughBakingTechnique, doughWeight);
				Pizza pizza = new Pizza(pizzaName, dough);

				string command = Console.ReadLine();

				while (command != "END")
				{
					string[] toppingTokens = command.
						Split(" ").ToArray();

					string toppingType = toppingTokens[1];
					double toppingWeight = double.Parse(toppingTokens[2]);

					Topping topping = new Topping(toppingType, toppingWeight);
					pizza.AddTopping(topping);

					command = Console.ReadLine();
				}

				Console.WriteLine(pizza);

			}
			catch (Exception ae)
			{

				Console.WriteLine(ae.Message);
			}
        }
    }
}
