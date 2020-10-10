using CarRental.Models;
using System.Collections.Generic;

namespace CarRental.Bussiness.Cars
{
    public class CarRepository : ICarRepository
    {
        public CarRepository()
        {
            System.Console.WriteLine("Car repository is initialized");
        }

        public List<Car> Cars
        {
            get
            {
                return new List<Car>()
                {
                    new Car { PlateId = "GD2323", Segment = Segment.Family },
                          new Car { PlateId = "GD2323", Segment = Segment.Premium },
                                new Car { PlateId = "GD2323", Segment = Segment.Sport }
                };
            }
        }
    }
}
