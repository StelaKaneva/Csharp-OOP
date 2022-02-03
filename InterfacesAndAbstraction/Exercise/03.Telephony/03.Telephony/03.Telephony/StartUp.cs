﻿using _03.Telephony.Exceptions;
using System;

namespace _03.Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ");
            string[] sites = Console.ReadLine().Split(" ");

            StationaryPhone stationaryPhone = new StationaryPhone();
            Smartphone smartphone = new Smartphone();

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                try
                {
                    if (phoneNumbers[i].Length == 7)
                    {
                        Console.WriteLine(stationaryPhone.Call(phoneNumbers[i]));
                    }
                    else if (phoneNumbers[i].Length == 10)
                    {
                        Console.WriteLine(smartphone.Call(phoneNumbers[i]));
                    }
                    else
                    {
                        throw new InvalidPhoneNumberException();
                    }
                }
                catch (InvalidPhoneNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            for (int i = 0; i < sites.Length; i++)
            {
                try
                {
                    Console.WriteLine(smartphone.Browse(sites[i]));
                }
                catch (InvalidURLException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
