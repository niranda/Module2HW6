namespace ShopApp.Models
{
    public class MaseratiGranCabrio : Sedan
    {
        public MaseratiGranCabrio(
          string name,
          double maxSpeedKmPH,
          DriveUnit driveUnit,
          double accelerationToHundredKmPH,
          double fuelConsumption,
          double price,
          double fuelTankSize,
          bool haveRoof,
          string roofMaterial)
          : base(name, maxSpeedKmPH, driveUnit, accelerationToHundredKmPH, fuelConsumption, price, fuelTankSize, haveRoof)
        {
            RoofMaterial = roofMaterial;
        }

        public string RoofMaterial { get; set; }
    }
}
