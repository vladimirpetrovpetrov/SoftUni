using System;

namespace _04._Numbers_Divided_by_3_Without_Reminder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i+=3)
            {
                if(i == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
