using System;

namespace Smart_Lili__for_loop_
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var priceW = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());
            var birthdayMoney = 0;
            var toyCount = 0;
            var moneyBirthdayCount = 0;
            var finalMoney = 0;
            var birthdayMoneyAll = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneyBirthdayCount += 1;
                    birthdayMoney = 10 + birthdayMoney;
                    birthdayMoneyAll = birthdayMoneyAll + birthdayMoney;
                }
                else if (i % 2 != 0)
                {
                    toyCount += 1;
                }

            }
            finalMoney = (birthdayMoneyAll - (moneyBirthdayCount)) + (toyCount * toyPrice);

            if (finalMoney >= priceW)
            {
                Console.WriteLine("Yes! {0}", (String.Format("{0:0.00}", (finalMoney - priceW))));
            }
            else
            {
                Console.WriteLine("No! {0}", (String.Format("{0:0.00}", (priceW - finalMoney))));
            }




        }
    }
}
