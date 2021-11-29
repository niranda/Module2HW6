using ShopApp.Models;

namespace ShopApp.Services.Abstractions
{
    public interface ILoggerService
    {
        void SuccessfulTemplate(PassengerCar[] cars);
        void SuccessfulBuildLog(PassengerCar[] cars, double taxiStationPrice);
        void SuccessfulSortLog(PassengerCar[] cars);
        void SuccessfulSearchLog(PassengerCar[] cars);
    }
}
