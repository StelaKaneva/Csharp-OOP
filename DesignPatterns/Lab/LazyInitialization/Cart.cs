using System;
using System.Collections.Generic;
using System.Text;

namespace LazyInitialization
{
    public class Cart
    {
        public Cart(string param)
        {
            Console.WriteLine("Initialized" + " " + param);
        }

        public int Balance { get; set; }
    }
}
