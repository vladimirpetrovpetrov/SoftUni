using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());

            var totalMin = hour * 60 + min + 15;
            hour = totalMin / 60;
            min = totalMin % 60;

            if (hour > 23)
            {
                hour = 0;
                if (min < 10)
                {
                    Console.WriteLine($"{hour}:0{min}");
                }
                else
                {
                    Console.WriteLine($"{hour}:{min}");
                }
            }
            else
            {
                if (min < 10)
                {
                    Console.WriteLine($"{hour}:0{min}");
                }
                else
                {
                    Console.WriteLine($"{hour}:{min}");
                }

            }





        }

    }
}
