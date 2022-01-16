using System;
using System.Collections.Generic;
using System.Text;

namespace ShadowingVariables
{
    public class TennisEvent : Event
    {

        public DateTime Duration { get; set; }

        public void Start()
        {
            Console.WriteLine("Zagrqvka!!!"); //Скриваме метода Start от базовия клас, но го викаме в метода на дъщерния клас.
            base.Start();
        }

        public void Print()
        {
            string Duration = "X";
            Duration = "X";
            this.Duration = DateTime.Now;
            base.Duration = 5;
        }

        public override string ToString()
        {
            return base.ToString() + "Tennisss";
        }
    }
}
