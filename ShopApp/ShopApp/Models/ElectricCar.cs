namespace ShopApp.Models
{
    public abstract class ElectricCar : PassengerCar
    {
        public ElectricCar(
            string name,
            double maxSpeedKmPH,
            DriveUnit driveUnit,
            double accelerationToHundredKmPH,
            double fuelConsumption,
            double price,
            double batteryVolume)
            : base(name, maxSpeedKmPH, driveUnit, accelerationToHundredKmPH, fuelConsumption, price)
        {
            BatteryVolume = batteryVolume;
        }

        public double BatteryVolume { get; set; }
    }
}
