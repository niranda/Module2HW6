namespace ShopApp.Models
{
    public abstract class FullAutopilotCar : ElectricCar
    {
        public FullAutopilotCar(
            string name,
            double maxSpeedKmPH,
            DriveUnit driveUnit,
            double accelerationToHundredKmPH,
            double fuelConsumption,
            double price,
            double batteryVolume,
            double autopilotVersion)
            : base(name, maxSpeedKmPH, driveUnit, accelerationToHundredKmPH, fuelConsumption, price, batteryVolume)
        {
            AutopilotVersion = autopilotVersion;
        }

        public double AutopilotVersion { get; set; }
    }
}
