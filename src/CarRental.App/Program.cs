using CarRental.Models;
using CarRental.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CarRental.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var carsStack = new List<Car>();
            carsStack.Add(new Car
            {
                PlateId = "GDXXXX01",
                Price = 123.04,
                Segment = Segment.Family,
                ReservationHistory = new List<Reservation>()
              {
                  new Reservation { StartDate = new DateTime(2020, 10, 8), EndDate = new DateTime(2020, 12, 9)},
                  new Reservation { StartDate = new DateTime(2020, 6, 8), EndDate = new DateTime(2020, 6, 9)},
                  new Reservation { StartDate = new DateTime(2020, 1, 8), EndDate = new DateTime(2020, 20, 12)}
              }
            });
            carsStack.Add(new Car
            {
                PlateId = "GDXXXX02",
                Price = 12332.04,
                Segment = Segment.Premium,
                ReservationHistory = new List<Reservation>()
              {
                  new Reservation { StartDate = new DateTime(2019, 10, 8), EndDate = new DateTime(2019, 12, 9)},
                  new Reservation { StartDate = new DateTime(2019, 6, 8), EndDate = new DateTime(2019, 6, 9)},
                  new Reservation { StartDate = new DateTime(2019, 1, 8), EndDate = new DateTime(2019, 20, 12)}
              }
            });
            carsStack.Add(new Car { PlateId = "GDXXXX03", Price = 122323.04, Segment = Segment.Sport });

            var filteredCars = new EnumberableSample().Where(c => c.IsReserved());

            var filteredCarsList = filteredCars.ToList();

            foreach (var c in filteredCarsList)
            {
                Console.WriteLine($"Car from foreach {c.PlateId}");
            }

        }
    }
}
