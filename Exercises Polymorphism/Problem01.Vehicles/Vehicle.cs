namespace Problem._02VehicleExtendet.Vehicles
{
    public abstract class Vehicle
    {
        private double FuelQuantity { get; set; }

        private double FuelConsumption { get; set; }

        public abstract double AdditionalConsumption { get; }

        public Vehicle(double fuelQuantity , double fuelConsumption) 
        {
            FuelQuantity = fuelQuantity;
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
            FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}