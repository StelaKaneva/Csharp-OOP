using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ValidationAttributes
{
    public class Person
    {
        public Person(string fullName, int age)
        {
            this.FullName = fullName;
            this.Age = age;
        }

        [MyRequiredAttribute]
        //[Range(12, 90)]
        public string FullName { get; set; }

        [MyRangeAttribute(12, 90)]
        //[Required]
        public int Age { get; set; }
    }
}
