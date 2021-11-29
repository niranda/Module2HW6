namespace ShopApp.Models
{
    public abstract class SUV : GasolineCar
    {
        public SUV(
           string name,
           double maxSpeedKmPH,
           DriveUnit driveUnit,
           double accelerationToHundredKmPH,
           double fuelConsumption,
           double price,
           double fuelTankSize,
           int numberOfAdditionalSeatings,
           bool haveBullbar)
           : base(name, maxSpeedKmPH, driveUnit, accelerationToHundredKmPH, fuelConsumption, price, fuelTankSize)
        {
            NumberOfAdditionalSeatings = numberOfAdditionalSeatings;
            HaveBullbar = haveBullbar;
        }

        public double NumberOfAdditionalSeatings { get; set; }
        public bool HaveBullbar { get; set; }
    }
}
