using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControl
{
    public class Citizen : IPerson
    {
        public Citizen(string iD, string name, int age)
        {
            ID = iD;
            Name = name;
            Age = age;
        }

        public string ID { get; }
        public string Name{ get;}
        public int Age { get;}
    }
}
