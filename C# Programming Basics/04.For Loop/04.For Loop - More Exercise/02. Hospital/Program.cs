using System;

namespace _02._Hospital
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int periodOfTime = int.Parse(Console.ReadLine());
            int treatedPacients = 0;
            int untreatedPacients = 0;
            int doctors = 7;

            for (int i = 1; i <= periodOfTime; i++)
            {
                int pacients = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    if (untreatedPacients > treatedPacients)
                    {
                        doctors++;
                    }
                }
                if (pacients <= doctors)
                {
                    treatedPacients += pacients;

                }
                else
                {
                    treatedPacients += doctors;
                    untreatedPacients += pacients - doctors;

                }
            }
            Console.WriteLine($"Treated patients: {treatedPacients}.");
            Console.WriteLine($"Untreated patients: {untreatedPacients}.");
        }
    }
}
