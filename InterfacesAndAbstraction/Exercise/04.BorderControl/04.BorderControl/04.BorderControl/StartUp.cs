using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.BorderControl
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IPerson> allTryingToEnter = new List<IPerson>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split(" ").ToArray();

                IPerson person;

                if (tokens.Length > 2)
                {
                    person = new Citizen(tokens[2], tokens[0], int.Parse(tokens[1]));
                }
                else
                {
                    person = new Robot(tokens[1], tokens[0]);
                }

                allTryingToEnter.Add(person);

                input = Console.ReadLine();
            }

            string fakeIdsDigits = Console.ReadLine();

            allTryingToEnter.Where(p => p.ID.EndsWith(fakeIdsDigits))
                            .Select(p => p.ID)
                            .ToList()
                            .ForEach(Console.WriteLine);
        }
    }
}
