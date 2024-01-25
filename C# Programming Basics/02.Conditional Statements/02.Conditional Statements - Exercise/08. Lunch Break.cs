using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var seriesName = Console.ReadLine();
            var episodeLenght = int.Parse(Console.ReadLine());
            var breakLenght = int.Parse(Console.ReadLine());

            var lunchLenght = 0.125 * breakLenght;
            var doingNothingLenht = breakLenght * 0.25;


            var breakLeft = breakLenght - (lunchLenght + doingNothingLenht);
            if (breakLeft >= episodeLenght)
            {
                var timeleft = Math.Ceiling(breakLeft - episodeLenght);
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {timeleft} minutes free time.");
            }
            else
            {
                var timeleft = Math.Ceiling(episodeLenght - breakLeft);
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {timeleft} more minutes.");
            }



            //String.Format("{0:0.00}",    )







        }
    }
}
