﻿using _04.WildFarm.Core;
using _04.WildFarm.Core.Contracts;
using System;

namespace _04.WildFarm
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
