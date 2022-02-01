using InterfacesAndAbstraction.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstraction
{
    public class Toothbrush : IPrice
    {
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int Whitening { get; set; }

        
    }
}
