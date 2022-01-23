using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{this.GetType().Name}");
            result.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            result.AppendLine($"{this.ProduceSound()}");

            return result.ToString().TrimEnd();

        }
        public abstract string ProduceSound();
    }
}
