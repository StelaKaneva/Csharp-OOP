using LoggerExercise.IOManagement.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerExercise.IOManagement
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
