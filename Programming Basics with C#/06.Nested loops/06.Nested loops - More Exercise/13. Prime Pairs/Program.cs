using System;

namespace _13._Prime_Pairs
{
    internal class Program
    {
        private static void Main(string[] args)
        {


            int start1 = int.Parse(Console.ReadLine());
            int start2 = int.Parse(Console.ReadLine());
            int dif1 = int.Parse(Console.ReadLine());
            int dif2 = int.Parse(Console.ReadLine());

            bool isPrime1 = true;
            int count = 0;
            bool isPrime2 = true;
            int count2 = 0;

            for (int first = start1; first <= start1 + dif1; first++)
            {
                for (int i = 2; i <= first; i++)
                {
                    if (first % i == 0)
                    {
                        count++;
                        if (count > 1)
                        {
                            isPrime1 = false;
                            break;
                        }
                    }
                }
                for (int second = start2; second <= start2 + dif2; second++)
                {
                    for (int j = 2; j <= second; j++)
                    {
                        if (second % j == 0)
                        {
                            count2++;
                            if (count2 > 1)
                            {
                                isPrime2 = false;
                                break;
                            }
                        }
                    }
                    if (isPrime1 && isPrime2)
                    {
                        Console.WriteLine($"{first}{second}");
                    }
                    count = 0;
                    count2 = 0;
                    isPrime2 = true;
                }
                isPrime1 = true;
            }



        }
    }
}
