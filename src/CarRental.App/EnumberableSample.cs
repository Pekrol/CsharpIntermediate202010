using CarRental.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CarRental.App
{
    class EnumberableSample : IEnumerable<Car>
    {
       

        public IEnumerator<Car> GetEnumerator()
        {
            Console.WriteLine("Enumerator is returned");
            return new MyEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    class MyEnumerator : IEnumerator<Car>
    {
        private Car _current = new Car() { PlateId = $"Car {DateTime.Now:HHmmss}" };

        public Car Current => _current;

        private int returnetCarsCount = 0;

        object IEnumerator.Current => null;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
           if (returnetCarsCount < 5)
            {
                Thread.Sleep(1000);
                Console.WriteLine("New car is generated and set as current");
                _current = new Car() { PlateId = $"Car {DateTime.Now:HHmmss}" };
            }

            returnetCarsCount++;
            return returnetCarsCount < 10;
        }

        public void Reset()
        {
        }
    }
}
