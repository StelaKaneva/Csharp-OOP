using _02.VehicleExtension.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02.VehicleExtension.IO.Models
{
    public class ConsoleWriter : IWritable
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
