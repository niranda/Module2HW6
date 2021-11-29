using ShopApp.Models;

namespace ShopApp.Providers.Abstractions
{
    public interface ITaxiStationProvider
    {
        int Capacity { get; set; }
        double TaxiStationPrice { get; set; }
        PassengerCar[] TaxiStation { get; set; }
    }
}
