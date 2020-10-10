using CarRental.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Bussiness.Reservations
{
    public interface IReservationModule
    {
        void ReserveCarFromSegment(Segment segment, DateTime startDate, DateTime endDate);
    }
}
