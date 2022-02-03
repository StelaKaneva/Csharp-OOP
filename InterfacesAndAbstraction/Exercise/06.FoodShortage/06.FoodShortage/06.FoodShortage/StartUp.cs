using _06.FoodShortage.Contracts;
using _06.FoodShortage.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FoodShortage
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IBuyer> buyers = new List<IBuyer>();

            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                var personInfo = Console.ReadLine().Split();

                if (personInfo.Length == 3)
                {
                    buyers.Add(new Rebel(personInfo[2], personInfo[0], int.Parse(personInfo[1])));
                }
                else if (personInfo.Length == 4)
                {
                    buyers.Add(new Citizen(int.Parse(personInfo[1]), personInfo[0], personInfo[3], personInfo[2]));
                }
            }

            string name = Console.ReadLine();

            while (name != "End")
            {
                var buyer = buyers.SingleOrDefault(b => b.Name == name);

                if (buyer != null)
                {
                    buyer.BuyFood();
                }

                name = Console.ReadLine();
            }

            Console.WriteLine(buyers.Sum(b => b.Food));
        }
    }
}
