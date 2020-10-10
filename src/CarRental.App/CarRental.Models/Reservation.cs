using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Models
{
    public class Reservation : IEquatable<Reservation>
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public double Price => (EndDate - StartDate).Days * 40;

        public bool Equals(Reservation other)
        {
            return Equals(this.StartDate, other.StartDate) && Equals(this.EndDate, other.EndDate);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"{StartDate:G} {EndDate:G}";
        }
    }
}
