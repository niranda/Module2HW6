using System;
using ShopApp.Models;
using ShopApp.Services.Abstractions;

namespace ShopApp.Services
{
    public class LoggerService : ILoggerService
    {
        public void SuccessfulTemplate(PassengerCar[] cars)
        {
            for (var i = 0; i < cars.Length; i++)
            {
                if (cars[i] == null)
                {
                    break;
                }

                Console.WriteLine($"{i + 1}. '{cars[i].Name}', price: {cars[i].Price} USD, fuelConsumption: {cars[i].FuelConsumption} km with one filling");
            }

            Console.WriteLine();
        }

        public void SuccessfulBuildLog(PassengerCar[] cars, double taxiStationPrice)
        {
            Console.WriteLine("The Taxi Station was built successfully! You can see the list of included cars below:");
            Console.WriteLine();
            SuccessfulTemplate(cars);
            Console.WriteLine($"Total taxi station price: {taxiStationPrice}");
            Console.WriteLine();
        }

        public void SuccessfulSortLog(PassengerCar[] cars)
        {
            Console.WriteLine("The cars were sorted successfully. Results are below:");
            Console.WriteLine();
            SuccessfulTemplate(cars);
        }

        public void SuccessfulSearchLog(PassengerCar[] cars)
        {
            Console.WriteLine("Your query was processed successfully. Results are below:");
            Console.WriteLine();
            SuccessfulTemplate(cars);
        }
    }
}
