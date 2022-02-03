using _05.BirthdayCelebrations.Contracts;
using _05.BirthdayCelebrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BirthdayCelebrations
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IBirthable> all = new List<IBirthable>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                var tokens = command.Split();

                if (tokens[0] == "Citizen")
                {
                    all.Add(new Citizen(tokens[4], tokens[1], tokens[3], int.Parse(tokens[2])));
                }
                else if (tokens[0] == "Pet")
                {
                    all.Add(new Pet(tokens[2],tokens[1]));
                }
                else if (tokens[0] == "Robot")
                {
                    command = Console.ReadLine();
                    continue;
                }

                command = Console.ReadLine();
            }

            string year = Console.ReadLine();

            all.Where(c => c.Birthdate.EndsWith(year))
                .Select(c => c.Birthdate)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
