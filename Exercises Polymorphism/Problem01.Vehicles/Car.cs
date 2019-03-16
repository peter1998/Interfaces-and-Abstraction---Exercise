using System;
using System.Collections.Generic;
using System.Text;

namespace Problem._02VehicleExtendet.Vehicles
{
    public class Car : Vehicle
    {
        private const double  additionalConsumptionPerKm = 0.9;

        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }

        public override double AdditionalConsumption => additionalConsumptionPerKm;
    }
}
