using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var points = int.Parse(Console.ReadLine());
            var bonus = 0.0;

            //Х	јко числото е до 100 включително, бонус точките са 5.
            //Х	јко числото е по-гол€мо от 100, бонус точките са 20 % от числото.
            //Х	јко числото е по-гол€мо от 1000, бонус точките са 10 % от числото.

            if (points <= 100)
            {
                bonus += 5;
            }
            else if (points > 100 && points <= 1000)
            {
                bonus = points * 0.20;
            }
            else
            {
                bonus = points * 0.10;
            }

            if (points % 2 == 0)
            {
                bonus += 1;
            }
            else if (points % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(bonus + points);



        }

    }
}
