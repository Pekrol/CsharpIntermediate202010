using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Models
{
    public class Reservation : IEquatable<Reservation>
    {
        public Reservation(double price)
        {
            Price = price;
        }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public double Price { get; }

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
