using System;
using System.Linq;
using System.Reflection;
using TestRunner.Framework.Attributes;

namespace TestRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Tests will be run here!");

            Type testContainterType = typeof(ReservationModuleTests);

            var testMethods = testContainterType
                .GetMethods()
                .Where(m => m.IsPublic
                && m.GetCustomAttributes().Any(attr => attr is TestMethodAttribute));

            foreach (var test in testMethods)
            {
                var objectToTest = Activator.CreateInstance(testContainterType);
                test.Invoke(objectToTest, null);
            }

            //Console.WriteLine(testContainterType);
        }
    }
}
