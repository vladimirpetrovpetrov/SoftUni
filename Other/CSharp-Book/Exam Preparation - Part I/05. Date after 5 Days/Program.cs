using System;

namespace _05._Date_after_5_Days
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            switch (m)
            {
                case 01:
                case 03:
                case 05:
                case 07:
                case 08:
                case 10:
                case 12:
                    d += 5;
                    if (d > 31)
                    {
                        m += 1;
                        if (m > 12)
                        {
                            m -= 12;
                        }
                        d -= 31;
                    }
                    if (m < 10)
                    {
                        Console.WriteLine($"{d}.0{m}");
                    }
                    else
                    {

                        Console.WriteLine($"{d}.{m}");
                    }
                    break;
                case 04:
                case 06:
                case 09:
                case 11:
                    d += 5;
                    if (d > 30)
                    {
                        m += 1;
                        if (m > 12)
                        {
                            m -= 12;
                        }
                        d -= 30;
                    }
                    if (m < 10)
                    {
                        Console.WriteLine($"{d}.0{m}");
                    }
                    else
                    {
                        Console.WriteLine($"{d}.{m}");
                    }
                    break;
                case 02:
                    d += 5;
                    if (d > 28)
                    {
                        m++;
                        if (m > 12)
                        {
                            m -= 12;
                        }
                        d -= 28;
                    }
                    if (m < 10)
                    {
                        Console.WriteLine($"{d}.0{m}");
                    }
                    else
                    {
                        Console.WriteLine($"{d}.{m}");
                    }
                    break;
                default:
                    break;
            }









        }
    }
}
