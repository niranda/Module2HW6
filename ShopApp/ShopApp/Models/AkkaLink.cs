namespace ShopApp.Models
{
    public class AkkaLink : FullAutopilotCar
    {
        public AkkaLink(
          string name,
          double maxSpeedKmPH,
          DriveUnit driveUnit,
          double accelerationToHundredKmPH,
          double fuelConsumption,
          double price,
          double batteryVolume,
          double autopilotVersion,
          double tvDiagonal)
          : base(name, maxSpeedKmPH, driveUnit, accelerationToHundredKmPH, fuelConsumption, price, batteryVolume, autopilotVersion)
        {
            TVDiagonal = tvDiagonal;
        }

        public double TVDiagonal { get; set; }
    }
}
