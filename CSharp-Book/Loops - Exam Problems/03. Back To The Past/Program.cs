using System;

namespace Back_to_the_future
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var age = 19;

            for (int i = 1800; i <= year; i++) // 1-va godina - 12 000 , 2-ra godina -
            {

                if (i % 2 == 0)
                {
                    money -= 12000;

                }
                else
                {

                    money -= (12000 + 50 * age);
                    age = age + 2;

                }


            }

            if (money >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0} dollars left.", String.Format("{0:0.00}", money));
            }
            else
            {
                money = Math.Abs(money);
                Console.WriteLine("He will need {0} dollars to survive.", String.Format("{0:0.00}", money));
            }

        }
    }
}
