using System;

namespace TRAINING
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var fahrenheit = 80;
            var result = String.Format("{0:0.0}", FtoC(fahrenheit));
            Console.WriteLine($"{fahrenheit}°F = {result}°C");

            var celsius = 35.5;
            var result2 = String.Format("{0:0.0}", CtoF(celsius));
            Console.WriteLine($"{celsius}°C = {result2}°F");
        }
        /// <summary>
        /// Converts fahrenheit to celsius.
        /// </summary>
        /// <param name="fahrenheit">Degrees in fahrenhait.</param>
        /// <returns></returns>
        static double FtoC(double fahrenheit)
        {
            double result = (fahrenheit - 32) * (5.00 / 9);
            return result;
        }
        /// <summary>
        /// Converts celsius to fahrenheit.
        /// </summary>
        /// <param name="celsius">Degrees in celsius.</param>
        /// <returns></returns>
        static double CtoF(double celsius)
        {
            double result = celsius * (9.00 / 5) + 32;

            return result;
        }




    }
}
