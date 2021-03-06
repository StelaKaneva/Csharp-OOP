using System;
using System.Collections.Generic;
using System.Text;

namespace _02.VehicleExtension.Common
{
    public static class ExceptionMessages
    {
        public static string NotEnoughFuelExceptionMessage =
            "{0} needs refueling";

        public static string InvalidtypeExceptionMessage =
            "Invalid vehicle type!";

        public static string InvalidFuelAmountMessage =
            "Fuel must be a positive number";

        public static string InvalidRefuelCommandMessage =
           "Cannot fit {0} fuel in the tank";
    }
}
