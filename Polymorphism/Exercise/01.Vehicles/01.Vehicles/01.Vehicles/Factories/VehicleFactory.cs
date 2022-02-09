using _01.Vehicles.Common;
using _01.Vehicles.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles.Factories
{
    public class VehicleFactory
    {
        public VehicleFactory()
        {

        }

        public Vehicle CreateVehicle(string vehicleType, double fuelQuantity, double fuelConsumption)
        {
            Vehicle vehicle;

            if (vehicleType == "Car")
            {
                vehicle = new Car(fuelQuantity, fuelConsumption);
            }
            else if (vehicleType == "Truck")
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.INVALID_VEHICLE_TYPE);
            }

            return vehicle;
        }
    }
}
