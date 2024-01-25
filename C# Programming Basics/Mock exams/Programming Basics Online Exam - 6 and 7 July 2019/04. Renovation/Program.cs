using System;

namespace _04._Renovation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int heightWall = int.Parse(Console.ReadLine());
            int widthWall = int.Parse(Console.ReadLine());

            double wholeRoom = heightWall * widthWall * 4;

            int percentNotForPainting = int.Parse(Console.ReadLine());

            wholeRoom -= wholeRoom * ((double)percentNotForPainting / 100);
            wholeRoom = Math.Ceiling(wholeRoom);
            int currentPainted = 0;
            while (true)
            {
                try
                {
                    int litersPaint = int.Parse(Console.ReadLine());
                    currentPainted += litersPaint;
                    while (currentPainted < wholeRoom)
                    {
                        litersPaint = int.Parse(Console.ReadLine());
                        currentPainted += litersPaint;


                    }
                    double litersPainLeft = currentPainted - wholeRoom;
                    if (litersPainLeft > 0)
                    {
                        Console.WriteLine($"All walls are painted and you have {litersPainLeft} l paint left!");
                    }
                    else if (litersPainLeft == 0)
                    {
                        Console.WriteLine("All walls are painted! Great job, Pesho!");
                    }

                    break;


                }
                catch
                {
                    Console.WriteLine($"{wholeRoom - currentPainted} quadratic m left.");

                    break;
                }




            }






        }
    }
}
