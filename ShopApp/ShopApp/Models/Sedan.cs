namespace ShopApp.Models
{
    public abstract class Sedan : GasolineCar
    {
        public Sedan(
          string name,
          double maxSpeedKmPH,
          DriveUnit driveUnit,
          double accelerationToHundredKmPH,
          double fuelConsumption,
          double price,
          double fuelTankSize,
          bool haveRoof)
          : base(name, maxSpeedKmPH, driveUnit, accelerationToHundredKmPH, fuelConsumption, price, fuelTankSize)
        {
            HaveRoof = haveRoof;
        }

        public bool HaveRoof { get; set; }
    }
}
