using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double FUEL_CONSUMPTION_INCR = 1.6;
        private const double REFUEL_SUCC_COEF = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }

        public override double FuelConsumption => base.FuelConsumption + FUEL_CONSUMPTION_INCR;

        public override void Refuel(double amount)
        {
            base.Refuel(amount * REFUEL_SUCC_COEF);
        }
    }
}
