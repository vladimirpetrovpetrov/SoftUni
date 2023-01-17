using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var salary = double.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string siteName = Console.ReadLine();
                if (siteName == "Facebook")
                {
                    salary = salary - 150;
                }
                else if (siteName == "Instagram")
                {
                    salary = salary - 100;
                }
                else if (siteName == "Reddit")
                {
                    salary = salary - 50;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }
            Console.WriteLine((int)salary);





        }
    }
}
