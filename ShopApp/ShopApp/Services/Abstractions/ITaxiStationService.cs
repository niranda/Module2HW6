using ShopApp.Models;

namespace ShopApp.Services.Abstractions
{
    public interface ITaxiStationService
    {
        void BuildTaxiStation(PassengerCar[] cars);
        PassengerCar[] GetTaxiStation();
        double GetTaxiStationPrice();
    }
}
