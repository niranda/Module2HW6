using System;
using ShopApp.Models;
using ShopApp.Helpers;
using ShopApp.Services.Abstractions;

namespace ShopApp.Services
{
    public class SortService : ISortService
    {
        public PassengerCar[] SortByConsumption(PassengerCar[] cars)
        {
            Array.Sort(cars, new FuelConsumptionComparerService());
            return cars;
        }
    }
}
