using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string command = "";
            var sumPrime = 0;
            var sumNotPrime = 0;

            while (command != "stop")
            {
                command = Console.ReadLine();
                if (command == "stop")
                {
                    Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
                    Console.WriteLine($"Sum of all non prime numbers is: {sumNotPrime}");
                    return;
                }
                else if (Convert.ToInt16(command) < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                if (PrimeOrNotPrime(Convert.ToInt16(command)))
                {
                    sumPrime += Convert.ToInt16(command);
                }
                else { sumNotPrime += Convert.ToInt16(command); }
            }

        }
        static bool PrimeOrNotPrime(int num)
        {
            var prime = (num > 1);
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {

                if (num % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime == false)
            {
                return false;
            }
            else { return true; }
        }
    }
}