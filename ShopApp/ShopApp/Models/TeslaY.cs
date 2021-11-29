namespace ShopApp.Models
{
    public class TeslaY : FullAutopilotCar
    {
        public TeslaY(
            string name,
            double maxSpeedKmPH,
            DriveUnit driveUnit,
            double accelerationToHundredKmPH,
            double fuelConsumption,
            double price,
            double batteryVolume,
            double autopilotVersion,
            double volumeOfSecondTrunk)
            : base(name, maxSpeedKmPH, driveUnit, accelerationToHundredKmPH, fuelConsumption, price, batteryVolume, autopilotVersion)
        {
            VolumeOfSecondTrunk = volumeOfSecondTrunk;
        }

        public double VolumeOfSecondTrunk { get; set; }
    }
}
