using System;

namespace _03._Stop_Number
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //With WHILE LOOP
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            while (m >= n)
            {

                if (m % 2 == 0 && m % 3 == 0)
                {
                    if (m == s)
                    {
                        return;
                    }
                    Console.Write(m + " ");



                }
                m--;
            }

            //With FOR LOOP
            //var n = int.Parse(Console.ReadLine());
            //var m = int.Parse(Console.ReadLine());
            //var s = int.Parse(Console.ReadLine()); //спиращо число

            //for (int i = m; i >= n; i--)
            //{
            //    if (i % 2 == 0 && i % 3 == 0)
            //    {
            //        if(i == s)
            //        {
            //            return;
            //        }
            //        Console.Write(i + " ");
            //    }
            //}
        }
    }
}
