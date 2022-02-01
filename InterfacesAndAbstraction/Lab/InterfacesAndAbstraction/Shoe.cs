using InterfacesAndAbstraction.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstraction
{
    public class Shoe : IPrice
    {
        public decimal Price { get; set; }
        public int Size { get; set; }
        public string Model { get; set; }
    }

}
