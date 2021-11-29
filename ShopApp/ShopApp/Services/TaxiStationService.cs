using System;
using ShopApp.Models;
using ShopApp.Providers.Abstractions;
using ShopApp.Services.Abstractions;

namespace ShopApp.Services
{
    public class TaxiStationService : ITaxiStationService
    {
        private readonly ITaxiStationProvider _taxiProvider;

        public TaxiStationService(ITaxiStationProvider taxiProvider)
        {
            _taxiProvider = taxiProvider;
        }

        public void BuildTaxiStation(PassengerCar[] cars)
        {
            var length = Math.Min(cars.Length, _taxiProvider.Capacity);
            for (var i = 0; i < length; i++)
            {
                if (cars[i] == null)
                {
                    break;
                }

                _taxiProvider.TaxiStation[i] = cars[i];
                _taxiProvider.TaxiStationPrice += cars[i].Price;
            }
        }

        public PassengerCar[] GetTaxiStation()
        {
            return _taxiProvider.TaxiStation;
        }

        public double GetTaxiStationPrice()
        {
            return _taxiProvider.TaxiStationPrice;
        }
    }
}
