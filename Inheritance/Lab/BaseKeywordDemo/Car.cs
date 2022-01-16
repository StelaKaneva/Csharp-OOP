using System;
using System.Collections.Generic;
using System.Text;

namespace BaseKeywordDemo
{
    public class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine($"Max speed is: {base.MaxSpeed}"); // Няма значение дали ще напишем base или без него - само MaxSpeed
        }
    }
}
