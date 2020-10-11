using System;
using System.Collections.Generic;
using System.Text;
using TestRunner.Framework.Attributes;

namespace TestRunner.Framework
{
    class PseudoMethods
    {
        [TestMethod]
        void Method_When_Then()
        {
            Console.WriteLine("Test is run");
        }
        // return new TestResult()
    }

}
