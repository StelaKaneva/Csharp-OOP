using _03.Raiding.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Raiding.IO.Models
{
    public class ConsoleReader : IReadable
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
