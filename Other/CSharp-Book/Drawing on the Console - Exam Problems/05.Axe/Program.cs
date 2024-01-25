using System;

namespace Axe_with_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //upper part
            var n = int.Parse(Console.ReadLine());
            var leftDash = n * 3;
            var midDash = 0;
            var rightDash = 2 * n - 2;
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}*{1}*{2}", new string('-', leftDash), new string('-', midDash), new string('-', rightDash));
                Console.WriteLine();
                midDash++;
                rightDash--;
            }

            //middle part . hammer handle 

            midDash--;
            rightDash++;
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write("{0}*{1}*{2}", new string('*', leftDash), new string('-', midDash), new string('-', rightDash));
                Console.WriteLine();
            }

            //lower part

            for (int i = 0; i < n / 2; i++)
            {
                if (i == (n / 2) - 1)
                {
                    Console.Write("{0}*{1}*{2}", new string('-', leftDash), new string('*', midDash), new string('-', rightDash));

                }
                else
                {
                    Console.Write("{0}*{1}*{2}", new string('-', leftDash), new string('-', midDash), new string('-', rightDash));
                    Console.WriteLine();
                }
                leftDash--;
                midDash++;
                midDash++;
                rightDash--;
            }
        }
    }
}
