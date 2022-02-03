using _05.BirthdayCelebrations.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebrations.Models
{
    public class Citizen : IBirthable, INameable, IIdentifiable
    {
        public Citizen(string birthdate, string name, string id, int age)
        {
            Birthdate = birthdate;
            Name = name;
            Id = id;
            Age = age;
        }

        public string Birthdate { get; }

        public string Name { get; }

        public string Id { get; }

        public int Age { get; }
    }
}
