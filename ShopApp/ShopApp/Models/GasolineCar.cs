namespace ShopApp.Models
{
    public abstract class GasolineCar : PassengerCar
    {
        public GasolineCar(
            string name,
            double maxSpeedKmPH,
            DriveUnit driveUnit,
            double accelerationToHundredKmPH,
            double fuelConsumption,
            double price,
            double fuelTankSize)
            : base(name, maxSpeedKmPH, driveUnit, accelerationToHundredKmPH, fuelConsumption, price)
        {
            FuelTankSize = fuelTankSize;
        }

        public double FuelTankSize { get; set; }
    }
}
