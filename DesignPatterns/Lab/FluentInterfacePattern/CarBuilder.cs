using System;
using System.Collections.Generic;
using System.Text;

namespace FluentInterfacePattern
{
    public class CarBuilder : ICarBuilder
    {
        public ICarBuilder BuildEngine(Car car)
        {
            car.Engine = "5000c";
            return this;
        }

        public ICarBuilder BuildTransmission(Car car)
        {
            car.Transsmision = "Best car transsmision";
            return this;
        }

        public ICarBuilder BuildTyres(Car car)
        {
            car.Tyres = "Mishelin";
            return this;
        }
    }
}
