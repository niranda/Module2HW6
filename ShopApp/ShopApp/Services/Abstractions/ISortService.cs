using ShopApp.Models;

namespace ShopApp.Services.Abstractions
{
    public interface ISortService
    {
        PassengerCar[] SortByConsumption(PassengerCar[] animals);
    }
}
