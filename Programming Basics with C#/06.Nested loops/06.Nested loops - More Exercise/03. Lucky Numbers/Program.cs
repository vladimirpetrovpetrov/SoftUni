using System;

namespace _03._Lucky_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int luckyNum = int.Parse(Console.ReadLine());

            for (int n1 = 1; n1 <= 9; n1++)
            {
                for (int n2 = 1; n2 <= 9; n2++)
                {
                    for (int n3 = 1; n3 <= 9; n3++)
                    {
                        for (int n4 = 1; n4 <= 9; n4++)
                        {
                            bool cond1 = (n1 + n2) == (n3 + n4);
                            bool cond2 = luckyNum % (n1 + n2) == 0;
                            if (cond1 && cond2)
                            {
                                Console.Write($"{n1}{n2}{n3}{n4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
