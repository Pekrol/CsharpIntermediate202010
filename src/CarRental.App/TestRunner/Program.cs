using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
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
            var classes = executingAssembly.GetExportedTypes()
                .Where(t => t.IsPublic && t.GetCustomAttributes().Any(a => a is TestClassAttribute));

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            foreach (var testClass in classes)
            {
                var testMethods = testClass
               .GetMethods()
               .Where(m => m.IsPublic
               && m.GetCustomAttributes().Any(attr => attr is TestMethodAttribute));

                Parallel.ForEach(testMethods, tm =>
                {
                    try
                    {
                        var objectToTest = Activator.CreateInstance(testClass);
                        tm.Invoke(objectToTest, null);
                    }
                    catch (Exception e)
                    {
                        if (e.InnerException is TestFailedException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{tm.Name} failed");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.WriteLine($"Unknown error occured during test {tm.Name}");
                        }
                    }
                }
                    );

                Console.WriteLine($"Parallel run finished {stopwatch.ElapsedMilliseconds}");
                stopwatch.Restart();

                Console.WriteLine($"{stopwatch.ElapsedMilliseconds}");

                foreach (var test in testMethods)
                {
                    try
                    {
                        var objectToTest = Activator.CreateInstance(testClass);
                        test.Invoke(objectToTest, null);
                    }
                    catch (Exception e)
                    {
                        if (e.InnerException is TestFailedException)
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

                Console.WriteLine($"Serial run finished {stopwatch.ElapsedMilliseconds}");
            }

            //Console.WriteLine(testContainterType);
        }
    }
}
