using _05.BirthdayCelebrations.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebrations.Models
{
    public class Pet : IBirthable, INameable
    {
        public Pet(string birthdate, string name)
        {
            Birthdate = birthdate;
            Name = name;
        }

        public string Birthdate { get; }

        public string Name { get; }
    }
}
