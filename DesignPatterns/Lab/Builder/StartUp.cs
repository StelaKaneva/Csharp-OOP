using System;

namespace BuilderPattern
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            CarBuilder builder = new CarBuilder();

            builder.BuildEngine(car);
            builder.BuildTransmission(car);
            builder.BuildTyres(car);

            Console.WriteLine(car.Engine);
            Console.WriteLine(car.Tyres);
            Console.WriteLine(car.Transsmision);
        }
    }
}
