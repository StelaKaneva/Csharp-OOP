using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public class Cat : Animal
    {
        public override void Sleep()
        {
            Console.WriteLine("Never sleep");
        }
    }
}
