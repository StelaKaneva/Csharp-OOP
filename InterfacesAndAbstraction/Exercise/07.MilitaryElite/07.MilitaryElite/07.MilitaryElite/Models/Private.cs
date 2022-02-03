using _07.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Models
{
    public class Private : Soldier, IPrivate
    {
        public Private(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }
        public decimal Salary { get; }

        public override string ToString()
        {
            return $"Name: {base.ToString()} Salary: {Math.Round(this.Salary, 2):f2}";
        }
    }
}
