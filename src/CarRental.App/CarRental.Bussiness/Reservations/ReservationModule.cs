using CarRental.Bussiness.Cars;
using CarRental.Models;
using Microsoft.Extensions.Configuration;
using System;

namespace CarRental.Bussiness.Reservations
{
    public class ReservationModule : IReservationModule
    {
        private readonly ICarRepository carRepository;
        private readonly IConfiguration config;

        public ReservationModule(ICarRepository carRepository, IConfiguration config)
        {
            this.carRepository = carRepository;
            this.config = config;
        }

        public void ReserveCarFromSegment(Segment segment, DateTime startDate, DateTime endDate)
        {
            Console.WriteLine($"Someone want to rent car from segment {segment}");

            Console.WriteLine($"Price is 10201392{config["Currency"]}");
            // filter car by segment
            // find
        }
    }
}
