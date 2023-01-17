using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var recordInSec = double.Parse(Console.ReadLine());
            var distInMeters = double.Parse(Console.ReadLine());
            var secPerOneMeter = double.Parse(Console.ReadLine());

            var delay = (Math.Floor(distInMeters / 15)) * 12.5;


            var recordInSecIvan = distInMeters * secPerOneMeter + delay;
            if (recordInSecIvan < recordInSec)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {String.Format("{0:0.00}", recordInSecIvan)} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {String.Format("{0:0.00}", (recordInSecIvan - recordInSec))} seconds slower.");
            }

        }
    }
}
