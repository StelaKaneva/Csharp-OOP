using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Example
{
    public class Programmer : IWorker
    {
        public void GetSalary()
        {
            Console.WriteLine("Undeserved");
        }

        public void Work()
        {
            Console.WriteLine("Slacking all day");
        }
    }
}
