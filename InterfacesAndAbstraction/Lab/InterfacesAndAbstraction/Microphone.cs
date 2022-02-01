using InterfacesAndAbstraction.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstraction
{
    public class Microphone : IPrice
    {
        public decimal Price { get; set; }
        public bool IsDesperatelyNeeded { get; set; }
        public string Model { get; set; }
    }
}
