using ShopApp.Models;
using ShopApp.Services.Abstractions;
using ShopApp.Providers.Abstractions;
using ShopApp.Configs;

namespace ShopApp.Providers
{
    public class TaxiStationProvider : ITaxiStationProvider
    {
        private readonly TaxiStationConfig _taxiStationConfig;
        private readonly Config _config;

        public TaxiStationProvider(IConfigService config)
        {
            _config = config.DeserializeConfig();
            _taxiStationConfig = _config.TaxiStation;
            Capacity = _taxiStationConfig.StationCapacity;
            TaxiStation = new PassengerCar[Capacity];
        }

        public int Capacity { get; set; }
        public PassengerCar[] TaxiStation { get; set; }
        public double TaxiStationPrice { get; set; }
    }
}
