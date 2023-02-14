using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ints = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
            int position = 0;
            while (true)
            {
                string initCommand = Console.ReadLine();
                if (initCommand == "Love!")
                {
                    break;
                }
                var c = initCommand.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                int length = int.Parse(c[1]);
                

                position += length;
                if(position > ints.Count - 1)
                {
                    position = 0;
                }
                if (ints[position] <= 0)
                {
                    Console.WriteLine($"Place {position} already had Valentine's day.");
                    continue;
                }
                ints[position] -= 2;
                if (ints[position] <= 0)
                {
                    Console.WriteLine($"Place {position} has Valentine's day.");
                }
            }
            Console.WriteLine($"Cupid's last position was {position}.");
            bool completed = true;
            int count = 0;
            foreach (var item in ints)
            {
                if(item > 0)
                {
                    completed = false;
                    count++;
                }
            }
            if(completed )
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {count} places.");
            }
        }
    }
}
