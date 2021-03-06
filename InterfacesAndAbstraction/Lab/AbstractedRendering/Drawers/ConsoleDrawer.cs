using AbstractedRendering.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractedRendering.Drawers
{
    public class ConsoleDrawer : IDrawer
    {
        public void Write(string input)
        {
            Console.Write(input);
        }

        public void WriteLine(string input)
        {
            Console.WriteLine(input);
        }
    }
}
