using System;

namespace Упражнения__.NET_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = 0;

            while (5 == 5)
            {

                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Chetno e");
                        break;
                    }
                    Console.WriteLine("Nechetno, opitai pak.");
                }
                catch (Exception)
                {

                    Console.WriteLine("Въвели сте невалиден вход.");
                }
            }
            Console.WriteLine($"Thanks, you've entered {n}");
        }
    }
}

