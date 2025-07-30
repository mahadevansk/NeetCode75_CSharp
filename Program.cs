using System;
using System.Globalization;
using System.Reflection;
using System.Text;

using Problems;

namespace NeetCode75_CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a problem name to run.");
                return;
            }

            string problemName = args[0]; // problem1 or problem2 etc. 

            // Convert the problem name to a class name
            // e.g., problem1 -> Problems.Problem1
            string className = $"Problems.{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(problemName)}"; //

            try
            {
                // Load the type dynamically
                Type type = Type.GetType(className, throwOnError: true);

                // Get the Run method from the type 
                MethodInfo runMethod = type.GetMethod("Run", BindingFlags.Public | BindingFlags.Static);

                if (runMethod != null)
                {
                    // Invoke the Run method
                    runMethod.Invoke(null, null);
                }
                else
                {
                    Console.WriteLine($"No Run method found in {className}.");
                }

            }
            catch (TypeLoadException)
            {
                Console.WriteLine($"Problem class {className} not found.");
            }
            catch (TargetInvocationException ex)
            {
                Console.WriteLine($"Error invoking Run method: {ex.InnerException?.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
        }

       
    }
}

