using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionDemo
{
    [Obsolete]
    public class Person
    {
        //private int age;

        public Person(double a)
        {
            this.A = a;
        }

        public double A { get; set; }

        public double GetA()
        {
            return A;
        }

        public string GetString()
        {
            return "123";
        }
    }
}
