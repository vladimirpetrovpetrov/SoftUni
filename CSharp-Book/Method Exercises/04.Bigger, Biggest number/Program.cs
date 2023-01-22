using System;

namespace TRAINING
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number1 = 1;
            int number2 = 0;
            int number3 = 3;

            Console.WriteLine(GetMax(number1, number2));
            Console.WriteLine(GetMax(number1, number2, number3));

        }
        /// <summary>
        /// Returns the larger number.
        /// </summary>
        /// <param name="num1">Number 1</param>
        /// <param name="num2">Number 2</param>
        /// <returns></returns>
        static int GetMax(int num1, int num2)
        {
            return Math.Max(num1, num2);
        }
        /// <summary>
        /// Return the largest from three numbers.
        /// </summary>
        /// <param name="num1">Number 1</param>
        /// <param name="num2">Number 2</param>
        /// <param name="num3">Number 3</param>
        /// <returns></returns>
        static int GetMax(int num1, int num2, int num3)
        {
            return (Math.Max(Math.Max(num1, num2), num3));
        }



    }
}
