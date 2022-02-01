using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Example
{
    public class FactoryMan : IWorker
    {
        public void GetSalary()
        {
            Console.WriteLine("Can get more");
        }

        public void Work()
        {
            Console.WriteLine("Hussling hard");
        }
    }
}
