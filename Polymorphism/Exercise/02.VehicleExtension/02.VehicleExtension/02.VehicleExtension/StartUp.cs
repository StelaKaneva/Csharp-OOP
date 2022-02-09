using _02.VehicleExtension.Core;
using _02.VehicleExtension.IO.Contracts;
using _02.VehicleExtension.IO.Models;
using System;

namespace _02.VehicleExtension
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IReadable reader = new ConsoleReader();
            IWritable writer = new ConsoleWriter();

            Engine engine = new Engine(reader, writer);
            engine.Run();
        }
    }
}
