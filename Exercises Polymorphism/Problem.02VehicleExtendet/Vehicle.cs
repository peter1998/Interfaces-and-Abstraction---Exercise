using System;

namespace Problem._02VehicleExtendet
{
    public abstract class Vehicle
    {
        protected double FuelQuantity { get; set; }

        private double FuelConsumption { get; set; }

        protected abstract double AdditionalConsumption { get; }

        private double TankCapacity { get; set; }

        public Vehicle(double fuelQuantity , double fuelConsumption,double tankCapacity) 
        {
            TankCapacity = tankCapacity;
            if (fuelQuantity>tankCapacity)
            {
                FuelQuantity = 0;
            }
            else
            {
                FuelQuantity = fuelQuantity;
            }
              FuelConsumption = fuelConsumption;
        }

        public string Drive(double distance)
        {
            double requredFuel = (FuelConsumption + AdditionalConsumption) * distance;

            if (requredFuel<=FuelQuantity)
            {
                FuelQuantity -= requredFuel;
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public virtual void Refuel(double fuel)
        {
            if (fuel<=0)
            {
                throw new ArgumentException($"Fuel must be a positive number");
            }

            if (fuel+FuelQuantity >TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }
            FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}