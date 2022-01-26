using System;

namespace ThisExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Name = "Audi";
            car.Drive(5);
            car.Drive(5);

            Car newCar = car.CreateCar();
        }

        class Car
        {
            public int Miles { get; set; }
            public string Name { get; set; }
            public void Drive(int Miles)
            {
                User.Drive(this);
                this.Miles += Miles;
            }

            public Car CreateCar()
            {
                Miles = 0;
                return this;
            }
        }

        class User
        {
            public static void Drive(Car car)
            {
                car.Miles += 50;
            }
        }
    }
}
