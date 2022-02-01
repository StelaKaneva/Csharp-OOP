using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Programmer : Worker
    {
        public override decimal Salary { get; set; }
        public override void Work()
        {
            Console.WriteLine("Ne rabotya dnes.");
        }
    }
}
