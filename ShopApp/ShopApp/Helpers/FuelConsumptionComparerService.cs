using System.Collections.Generic;
using ShopApp.Models;

namespace ShopApp.Helpers
{
    public class FuelConsumptionComparerService : IComparer<PassengerCar>
    {
        public int Compare(PassengerCar firstCar, PassengerCar secondCar)
        {
            if (firstCar == null || secondCar == null)
            {
                return 0;
            }
            else if (firstCar.FuelConsumption > secondCar.FuelConsumption)
            {
                return 1;
            }
            else if (firstCar.FuelConsumption < secondCar.FuelConsumption)
            {
                return -1;
            }

            return 0;
        }
    }
}
