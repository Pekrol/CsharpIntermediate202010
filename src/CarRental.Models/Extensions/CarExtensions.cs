using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Models.Extensions
{
    public static class CarExtensions
    {
        public static bool IsReserved(this Car car) // car.IsReserved IsReserved(car)
        {
            if (car.ReservationHistory == null)
            {
                return false;
            }

            foreach (var reservation in car.ReservationHistory)
            {
                if (reservation.EndDate > DateTime.Now && reservation.StartDate <= DateTime.Now)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
