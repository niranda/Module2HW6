using ShopApp.Models;
using ShopApp.Services.Abstractions;

namespace ShopApp.Helpers
{
    public static class GiftServiceExtension
    {
        public static PassengerCar[] FindCarsPriceLessThanCriterion(this ITaxiStationService taxiStationService, double criterion)
        {
            var carsArray = taxiStationService.GetTaxiStation();
            var outputCarsArray = new PassengerCar[carsArray.Length];
            var outputIndex = 0;
            for (var i = 0; i < carsArray.Length; i++)
            {
                if (carsArray[i] == null)
                {
                    break;
                }

                if (carsArray[i].Price < criterion)
                {
                    outputCarsArray[outputIndex] = carsArray[i];
                    outputIndex++;
                }
            }

            return outputCarsArray;
        }
    }
}
