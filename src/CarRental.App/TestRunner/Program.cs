using CarRental.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using TestRunner.Framework.Assertions;
using TestRunner.Framework.Attributes;
using TestRunner.Framework.Exceptions;

namespace TestRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Tests will be run here!");

            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            var classes = executingAssembly.GetExportedTypes();

            Type testContainterType = typeof(ReservationModuleTests);

            var testMethods = testContainterType
                .GetMethods()
                .Where(m => m.IsPublic
                && m.GetCustomAttributes().Any(attr => attr is TestMethodAttribute));

            foreach (var test in testMethods)
            {
                try
                {
                    var objectToTest = Activator.CreateInstance(testContainterType);
                    test.Invoke(objectToTest, null);
                }
                catch(Exception e)
                {
                    if(e.InnerException is TestFailedException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{test.Name} failed");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.WriteLine($"Unknown error occured during test {test.Name}");
                    }
              
                }
               
            }

            //Console.WriteLine(testContainterType);
        }
    }
}
