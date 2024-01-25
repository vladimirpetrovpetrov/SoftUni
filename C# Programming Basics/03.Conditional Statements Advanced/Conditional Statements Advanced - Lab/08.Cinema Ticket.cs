using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {



            var day = Console.ReadLine();

            var result = 0;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    result = 12;
                    break;
                case "Wednesday":
                case "Thursday":
                    result = 14;
                    break;
                case "Saturday":
                case "Sunday":
                    result = 16;
                    break;
                default:
                    break;
            }
            Console.WriteLine(result);


        }
    }
}
