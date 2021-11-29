using ShopApp.Models;
using ShopApp.Services.Abstractions;
using ShopApp.Helpers;

namespace StyleCop.Main
{
    public class Starter
    {
        private readonly ITaxiStationService _taxiStationService;
        private readonly ILoggerService _notification;
        private readonly ISortService _sort;

        public Starter(ITaxiStationService taxiStationService, ILoggerService notification, ISortService sort)
        {
            _taxiStationService = taxiStationService;
            _notification = notification;
            _sort = sort;
        }

        public void Run()
        {
            var bmw = new BMWX5("BMW X5", 350, DriveUnit.FourWheelDrive, 4.4, 5.5, 30000, 20, 2, false, "Sport 2");
            var maserati = new MaseratiGranCabrio("Maserati GranCabrio 2010", 400, DriveUnit.RearDrive, 3, 3.8, 50000, 15, true, "tarpaulin");
            var tesla = new TeslaY("Tesla Model Y", 230, DriveUnit.FrontWheelDrive, 6, 120, 60000, 500, 8.2, 200);
            var akka = new AkkaLink("Akka Link And Go 2.0", 120, DriveUnit.RearDrive, 15, 230, 23000, 150, 6.3, 40);

            var availableCars = new PassengerCar[4] { bmw, maserati, tesla, akka };

            _taxiStationService.BuildTaxiStation(availableCars);
            var taxiStation = _taxiStationService.GetTaxiStation();
            var totalPrice = _taxiStationService.GetTaxiStationPrice();
            _notification.SuccessfulBuildLog(taxiStation, totalPrice);

            var sortedByConsumption = _sort.SortByConsumption(taxiStation);
            _notification.SuccessfulSortLog(sortedByConsumption);

            var searchResult = _taxiStationService.FindCarsPriceLessThanCriterion(50000);
            _notification.SuccessfulSearchLog(searchResult);

            searchResult = _taxiStationService.FindCarsPriceLessThanCriterion(30000);
            _notification.SuccessfulSearchLog(searchResult);
        }
    }
}
