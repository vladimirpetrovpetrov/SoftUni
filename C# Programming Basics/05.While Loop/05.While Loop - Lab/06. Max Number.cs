using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var command = Console.ReadLine();
            var maxNumber = int.MinValue;

            while (command != "Stop")
            {
                int number = int.Parse(command);
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);

        }
    }
}
