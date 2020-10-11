using System;
using TestRunner.Framework.Attributes;

namespace TestRunner
{
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
        }
    }
}
