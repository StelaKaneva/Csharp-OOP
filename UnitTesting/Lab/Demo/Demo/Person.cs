using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Person
    {
        public Person(string name, decimal savedMoney)
        {
            this.Name = name;
            this.SavedMoney = savedMoney;
        }

        public string Name { get; set; }
        public decimal SavedMoney { get; set; }

        public string WhatsMyName()
        {
            return $"My name is {this.Name}";

            //throw new NotImplementedException();
        }
    }
}
