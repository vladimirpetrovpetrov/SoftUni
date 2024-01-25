using System;

namespace Тренировка
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //var n = int.Parse(Console.ReadLine());
            var word = Console.ReadLine();
            var sum = 0;
            foreach (char c in word)
            {
                if (c == 'a')
                {
                    sum++;
                }
                else if (c == 'e')
                {
                    sum += 2;
                }
                else if (c == 'i')
                {
                    sum += 3;
                }
                else if (c == 'o')
                {
                    sum += 4;
                }
                else if (c == 'u')
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
