using _03.Raiding.IO.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Raiding.IO.Models
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
