using System;
using TestRunner.Framework.Assertions;
using TestRunner.Framework.Attributes;
using CarRental.Bussiness.Reservations;

namespace TestRunner
{
    [TestClass]
    public class ReservationModuleTests
    {
        [TestMethod]
        public void ReserveCarFromSegment_WhenNotAvaiable_ShouldNotThrow()
        {
            Console.WriteLine("Reserve car test");
        }

        [TestMethod]
        public void ReserveCarFromSegment_WhenAvaiable_ShouldBeAdded()
        {
            Console.WriteLine("Reserve car test - should be added");
        }

        [TestMethod]
        public void ReserveCarFromSegment_WhenAlreadyReserved_ShouldNotThrow()
        {
        
            Console.WriteLine("Reserve car test - already reserved");
            var reservationModule = new ReservationModule(null, null);
            reservationModule.True(r => r.Available);
        }
    }
}
