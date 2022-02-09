using _03.Raiding.Core;
using _03.Raiding.IO.Contracts;
using _03.Raiding.IO.Models;
using System;

namespace _03.Raiding
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
