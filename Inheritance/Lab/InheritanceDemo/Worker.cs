using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    public class Worker : Person
    {
        public Worker(string company)
        {
            Company = company;
            Console.WriteLine("In the worker constructor");
        }

        public Worker()
        {
            Console.WriteLine("In the empty worker constructor");
        }

        public string Company { get; set; }
        public bool isLazy { get { return true; }}
    }
}
