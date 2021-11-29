namespace ShopApp.Models
{
    public class BMWX5 : SUV
    {
        public BMWX5(
          string name,
          double maxSpeedKmPH,
          DriveUnit driveUnit,
          double accelerationToHundredKmPH,
          double fuelConsumption,
          double price,
          double fuelTankSize,
          int numberOfAdditionalSeatings,
          bool haveBullbar,
          string subModel)
          : base(name, maxSpeedKmPH, driveUnit, accelerationToHundredKmPH, fuelConsumption, price, fuelTankSize, numberOfAdditionalSeatings, haveBullbar)
        {
            SubModel = subModel;
        }

        public string SubModel { get; set; }
    }
}
