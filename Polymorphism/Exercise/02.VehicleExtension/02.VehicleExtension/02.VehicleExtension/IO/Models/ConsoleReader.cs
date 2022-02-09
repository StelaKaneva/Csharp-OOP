using _02.VehicleExtension.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02.VehicleExtension.IO.Models
{
    public class ConsoleReader : IReadable
    {
        public string ReadLine() => Console.ReadLine();
    }
}
