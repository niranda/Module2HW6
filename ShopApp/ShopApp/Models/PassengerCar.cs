namespace ShopApp.Models
{
    public abstract class PassengerCar
    {
        public PassengerCar(
            string name,
            double maxSpeedKmPH,
            DriveUnit driveUnit,
            double accelerationToHundredKmPH,
            double fuelConsumption,
            double price)
        {
            Name = name;
            MaxSpeedKmPH = maxSpeedKmPH;
            DriveUnit = driveUnit;
            AccelerationToHundredKmPH = accelerationToHundredKmPH;
            FuelConsumption = fuelConsumption;
            Price = price;
        }

        public string Name { get; set; }
        public double MaxSpeedKmPH { get; set; }
        public DriveUnit DriveUnit { get; set; }
        public double AccelerationToHundredKmPH { get; set; }
        public double FuelConsumption { get; set; }
        public double Price { get; set; }
    }
}
