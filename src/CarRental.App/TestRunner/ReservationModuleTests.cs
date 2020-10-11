using System;
using TestRunner.Framework.Assertions;
using TestRunner.Framework.Attributes;
using CarRental.Bussiness.Reservations;
using System.Threading;

namespace TestRunner
{
    [TestClass]
    public class ReservationModuleTests
    {
        [TestMethod]
        public void ReserveCarFromSegment_WhenNotAvaiable_ShouldNotThrow()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Reserve car test");
        }

        [TestMethod]
        public void ReserveCarFromSegment_WhenAvaiable_ShouldBeAdded()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Reserve car test - should be added");
        }

        [TestMethod]
        public void ReserveCarFromSegment_WhenAlreadyReserved_ShouldNotThrow()
        {

            Thread.Sleep(3000);
            Console.WriteLine("Reserve car test - already reserved");
            var reservationModule = new ReservationModule(null, null);
            reservationModule.True(r => r.Available);
        }
    }
}
