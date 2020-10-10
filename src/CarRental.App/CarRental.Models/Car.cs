using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Models
{
    public class Car
    {
        public string PlateId { get; set; }

        public Segment Segment { get; set; }

        public double Price { get; set; }

        public List<Reservation> ReservationHistory { get; set; }

        //public bool IsReserved()
        //{
        //    foreach(var reservation in ReservationHistory)
        //    {
        //        if (reservation.EndDate < DateTime.Now && reservation.StartDate >= DateTime.Now)
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}
    }
}
