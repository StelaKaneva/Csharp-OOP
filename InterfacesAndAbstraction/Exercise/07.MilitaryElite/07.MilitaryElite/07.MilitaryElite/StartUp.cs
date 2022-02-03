using _07.MilitaryElite.Interfaces;
using _07.MilitaryElite.Models;
using System;
using System.Collections.Generic;

namespace _07.MilitaryElite
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<ISoldier> soldiers = new List<ISoldier>();

            string command;

            ISoldier soldier;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandTokens = command.Split();

                string soldierType = commandTokens[0];

                if (soldierType == typeof(Private).Name)
                {
                    soldier = new Private();
                }
                else if (soldierType == typeof(LieutenantGeneral).Name)
                {
                    List<IPrivate> lePr = new List<IPrivate>();
                }
            }

            PrintResult(soldiers);
        }

        public static void PrintResult(List<ISoldier> soldiers)
        {
            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}
