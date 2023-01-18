using System;

namespace _14._Password_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            for (int n1 = 1; n1 <= n; n1++)
            {
                for (int n2 = 1; n2 <= n; n2++)
                {
                    for (char l1 = 'a'; l1 <= 'a'+(l-1); l1++)
                    {
                        for (char l2 = 'a'; l2 <= 'a'+(l-1); l2++)
                        {
                            for (int n3 = 1; n3 <= n; n3++)
                            {
                                bool condition1 = n3 > n1 && n3 > n2;
                                if (condition1)
                                {
                                    Console.Write($"{n1}{n2}{l1}{l2}{n3} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
