using System;

namespace _08._Secret_Door_s_Lock
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int count = 0;
            bool isSimple = true;

            for (int i = 2; i <= n1; i++)
            {
                for (int j = 2; j <= n2; j++)
                {
                    for (int simple = 2; simple <= j; simple++)
                    {
                        if (j % simple == 0)
                        {
                            count++;
                        }
                        if (count > 1)
                        {
                            isSimple = false;
                            break;
                        }
                    }
                    for (int k = 2; k <= n3; k++)
                    {
                        if (isSimple == false)
                        {
                            break;
                        }
                        bool cond1 = i % 2 == 0 && k % 2 == 0;
                        if (cond1 && isSimple)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                    isSimple = true;
                    count = 0;
                }
            }







        }
    }
}
