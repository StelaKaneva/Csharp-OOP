using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class CarBuilder : ICarBuilder
    {
        public void BuildEngine(Car car)
        {
            car.Engine = "5000c";
        }

        public void BuildTransmission(Car car)
        {
            car.Transsmision = "Best car transsmision";
        }

        public void BuildTyres(Car car)
        {
            car.Tyres = "Mishelin";
        }
    }
}
