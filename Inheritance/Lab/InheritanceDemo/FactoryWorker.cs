using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    public class FactoryWorker : Worker
    {
        public FactoryWorker() : base("factoryCompany")
        {
            Console.WriteLine("In the factoryWorker Constructor");
        }

        public FactoryWorker(string factoryCompany) : base(factoryCompany)
        {
            Console.WriteLine("In the factoryWorker Constructor");
        }
    }
}
