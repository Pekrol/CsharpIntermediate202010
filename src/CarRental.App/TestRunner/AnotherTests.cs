using System;
using System.Collections.Generic;
using System.Text;
using TestRunner.Framework.Attributes;

namespace TestRunner
{
    [TestClass]
    public class AnotherTests
    {
        [TestMethod]
        public void Another_Test_Method()
        {
            Console.WriteLine("Another test method");
        }
    }
}
