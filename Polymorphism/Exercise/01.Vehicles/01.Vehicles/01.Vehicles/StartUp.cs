﻿using _01.Vehicles.Core;
using _01.Vehicles.Core.Contracts;
using System;

namespace _01.Vehicles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
