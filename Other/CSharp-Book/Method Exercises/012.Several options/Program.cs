using System;
using System.Linq;

namespace Several_options
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Reverse digits of a number [1...50,000,000]
            //2. Average of a sequance of numbers
            //3. Solved a*x + b = 0
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1. Reverse digits of a number [1...50,000,000].\n2. Find average of sequence of numbers.\n3. Solve \"a*x + b = 0\" ");
            var chosenOption = int.Parse(Console.ReadLine());
            if (chosenOption == 1)
            {
                Console.Write("Enter the number: ");
                var number = int.Parse(Console.ReadLine());
                while (number < 1 || number > 50000000)
                {
                    Console.WriteLine("Invalid Number try again:");
                    number = int.Parse(Console.ReadLine());
                }
                Console.WriteLine(ReverseNumberDigits(number));
            }
            else if (chosenOption == 2)
            {
                Console.WriteLine("Type the number with one space between them: ");
                Console.WriteLine(AverageOfSeqNums(Console.ReadLine().Split(' ').Select(int.Parse).ToArray()));
            }
            else if (chosenOption == 3)
            {
                Console.WriteLine("Enter 'a' : ");
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter 'b' : ");
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(SolveTheEquation(a, b));

            }


        }
        static double SolveTheEquation(double num1, double num2)
        {
            return -num2 / num1;
        }
        static int ReverseNumberDigits(int number)
        {
            var num = "";
            while (number > 0)
            {
                num += number % 10;
                number /= 10;
            }
            var result = int.Parse(num);
            return result;
        }
        static double AverageOfSeqNums(int[] arr)
        {
            return arr.Average();
        }





    }
}
