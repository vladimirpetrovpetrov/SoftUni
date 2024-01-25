using System;

namespace _06._Wedding_Seats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sector = char.Parse(Console.ReadLine());
            var rowsSectorA = int.Parse(Console.ReadLine());
            var seatsOddRow = int.Parse(Console.ReadLine());
            var count = 0;
            for (int sektor = 'A'; sektor <= sector; sektor++)
            {
                for (int row = 1; row <= rowsSectorA; row++)
                {  
                    if (row % 2 != 0)
                    {
                        for (char seat = 'a'; seat < 'a' +seatsOddRow; seat++)
                        {
                            Console.WriteLine($"{(char)sektor}{row}{seat}");
                            count++;
                        }
                    }
                    else
                    {
                        for (char seat = 'a'; seat < 'a' + seatsOddRow +2; seat++)
                        {
                            Console.WriteLine($"{(char)sektor}{row}{seat}");
                            count++;
                        }

                    }
                }
                rowsSectorA++;
            }
            Console.WriteLine(count);
        }
    }
}
