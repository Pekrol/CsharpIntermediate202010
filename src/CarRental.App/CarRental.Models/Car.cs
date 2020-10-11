using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarRental.Models
{
    public class Car
    {
        public string PlateId { get; set; }

        public Segment Segment { get; set; }

        public List<Reservation> ReservationHistory { get; set; }

    }
}
