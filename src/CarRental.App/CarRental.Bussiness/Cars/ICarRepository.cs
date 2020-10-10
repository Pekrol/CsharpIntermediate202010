using CarRental.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Bussiness.Cars
{
    public interface ICarRepository
    {
        List<Car> Cars { get; }
    }
}
