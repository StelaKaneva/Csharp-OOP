using _02.VehicleExtension.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02.VehicleExtension.Factories
{
    public class VehicleFactory
    {
        public Vehicle CreateVehicle(string type, double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            Vehicle vehicle = null;
            if (type == "Car")
            {
                vehicle = new Car(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (type == "Truck")
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else if (type == "Bus")
            {
                vehicle = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
            }
            if (vehicle == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidtypeExceptionMessage);
            }

            return vehicle;
        }
    }
}
