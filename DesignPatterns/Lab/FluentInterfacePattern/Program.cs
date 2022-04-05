using System;

namespace FluentInterfacePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            CarBuilder builder = new CarBuilder();

            builder.BuildEngine(car)
                    .BuildTransmission(car)
                    .BuildTyres(car);// Tova moje da se povtarya do bezkray, zashtoto vryshtame syshtiq obekt/nqkoy metod -> ot tam i method chaining.

            Console.WriteLine(car.Engine);
            Console.WriteLine(car.Tyres);
            Console.WriteLine(car.Transsmision);
        }
    }
}
