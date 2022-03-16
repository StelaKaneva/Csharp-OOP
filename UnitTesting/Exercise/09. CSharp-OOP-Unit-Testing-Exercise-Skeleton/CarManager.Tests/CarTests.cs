using CarManager;
using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("VW", "Golf", 10, 100)]
        [TestCase("BMW", "3", 20, 200)]
        public void CarConstructorsShouldSetAllDataCorrectly(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            //Arrange - Act
            Car car = new Car(
                make: make,
                model: model,
                fuelConsumption: fuelConsumption,
                fuelCapacity: fuelCapacity);

            //Assert
            Assert.AreEqual(car.Make, make);
            Assert.AreEqual(car.Model, model);
            Assert.AreEqual(car.FuelConsumption, fuelConsumption);
            Assert.AreEqual(car.FuelCapacity, fuelCapacity);
            Assert.AreEqual(car.FuelAmount, 0);
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void CarConstructorShouldThrowExceptionIfMakeIsNullOrEmpty(string make)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, "model", 10, 10));
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void CarConstructorShouldThrowExceptionIfModelIsNullOrEmpty(string model)
        {
            Assert.Throws<ArgumentException>(() => new Car("make", model, 10, 10));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-5)]
        public void CarConstructorShouldThrowExceptionIfFuelConsumptionIsZeroOrNegative(double fuelConsumption)
        {
            Assert.Throws<ArgumentException>(() => new Car("make", "model", fuelConsumption, 10));
        }

        [Test]
        [TestCase(-50)]
        [TestCase(0)]
        public void CarConstructorShouldThrowExceptionIfFuelCapacityIsZeroOrNegative(double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car("make", "model", 10, fuelCapacity));
        }

        [Test]
        [TestCase(-100)]
        [TestCase(0)]
        public void RefuelShouldThrowExceptionIfPassedValueIsZeroOrNegative(double fuelToRefuel)
        {
            Car car = new Car("VW", "Golf", 10, 100);

            Assert.Throws<ArgumentException>(() => car.Refuel(fuelToRefuel));
        }

        [Test]
        [TestCase(100, 50, 50)]
        [TestCase(200, 350, 200)]
        public void RefuelShouldWorkAsExpected(double fuelCapacity, double fuelToRefuel, double expectedResult)
        {
            //Arrange
            Car car = new Car("VW", "Golf", 10, fuelCapacity);

            //Act
            car.Refuel(fuelToRefuel);

            //Assert
            var actualResult = car.FuelAmount;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(30, 1000)]
        [TestCase(50, 501)]
        public void DriveShouldThrowExceptionIfFuelAmountIsNotEnough(double fuelToRefuel, double distance)
        {
            //Arrange
            Car car = new Car("VW", "Golf", 10, 100);

            //Act
            car.Refuel(fuelToRefuel);

            //Assert
            Assert.Throws<InvalidOperationException>(() => car.Drive(distance));
        }

        [Test]
        [TestCase(100, 100, 90)]
        public void DriveShouldWorkAsExpected(double fuelToRefuel, double distance, double expectedResult)
        {
            //Arrange
            Car car = new Car("VW", "Golf", 10, 200);

            //Act
            car.Refuel(fuelToRefuel);
            car.Drive(distance);

            //Assert
            double actualResult = car.FuelAmount;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}