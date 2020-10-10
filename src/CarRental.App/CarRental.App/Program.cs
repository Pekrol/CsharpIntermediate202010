using CarRental.Models;
using CarRental.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
                Segment = Segment.Family,
                ReservationHistory = new List<Reservation>()
              {
                  new Reservation(12) { StartDate = new DateTime(2020, 10, 8), EndDate = new DateTime(2020, 12, 9)},
                  new Reservation(12) { StartDate = new DateTime(2020, 10, 8), EndDate = new DateTime(2020, 6, 12)},
                  new Reservation(12) { StartDate = new DateTime(2020, 1, 8), EndDate = new DateTime(2020, 11, 12)}
              }
            });
            carsStack.Add(new Car
            {
                PlateId = "GDXXXX02",
                Segment = Segment.Premium,
                ReservationHistory = new List<Reservation>()
              {
                  new Reservation(12) { StartDate = new DateTime(2019, 10, 8), EndDate = new DateTime(2019, 12, 9)},
                  new Reservation(12) { StartDate = new DateTime(2020, 6, 8), EndDate = new DateTime(2020, 6, 9)},
                  new Reservation(12) { StartDate = new DateTime(2019, 1, 8), EndDate = new DateTime(2019, 11, 12)}
              }
            });
            carsStack.Add(new Car { PlateId = "GDXXXX03", Price = 122323.04, Segment = Segment.Sport });

            var filteredCars = carsStack.Where(c => c.IsReserved());

            var emptyEnumerable = Enumerable.Empty<Car>();
            var range = Enumerable.Range(10, 200);

            var reservations = carsStack.Where(c => c.ReservationHistory != null)
                .SelectMany(c => c.ReservationHistory)
                .ToList();

            var expectedIncome = reservations.Aggregate(0.0, (income, next) => income += next.Price);

            var expectedIncome2 = reservations.Select(r => r.Price).Sum();

            var carToReserve = carsStack
                //.Where()
                .FirstOrDefault(c => c.ReservationHistory != null && !c.IsReserved());

            Console.WriteLine($"Reserved car: {carToReserve?.PlateId}");

            var emptyNumberList = Enumerable.Empty<int>().ToList();
        }

        private class ReservationComparer : IEqualityComparer<Reservation>
        {
            public bool Equals([AllowNull] Reservation x, [AllowNull] Reservation y)
            {
                return Equals(x.StartDate, y.StartDate) && Equals(x.EndDate, y.EndDate);
            }

            public int GetHashCode([DisallowNull] Reservation obj)
            {
                return 0;
            }
        }
    }
}
