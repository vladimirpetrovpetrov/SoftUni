using System;

namespace Tennis_World_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {


            var tCount = int.Parse(Console.ReadLine());
            var startingPoints = double.Parse(Console.ReadLine());
            var finalPoints = startingPoints;
            var wCount = 0.0;
            for (int i = 0; i < tCount; i++)
            {
                var tStage = Console.ReadLine();

                if (tStage == "W")
                {
                    finalPoints = finalPoints + 2000;
                    wCount += 1;
                }
                else if (tStage == "F")
                {
                    finalPoints = finalPoints + 1200;
                }
                else if (tStage == "SF")
                {
                    finalPoints = finalPoints + 720;
                }
            }
            Console.WriteLine("Final points: {0}", finalPoints);
            Console.WriteLine("Average points: {0}", Math.Floor((finalPoints - startingPoints) / tCount));
            Console.WriteLine(String.Format("{0:0.00}", (wCount / tCount) * 100) + "%");





        }
    }
}
