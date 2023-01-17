using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var neededMoney = double.Parse(Console.ReadLine());
            var moneyATM = double.Parse(Console.ReadLine());
            var countDaysWithSpending = 0;
            var countDays = 0;

            while (countDaysWithSpending <5 && moneyATM < neededMoney)
            {
                var action = Console.ReadLine();    
                var currentSum = double.Parse(Console.ReadLine());

                if(action == "spend")
                {
                    countDaysWithSpending++;
                    moneyATM -= currentSum;
                    if(moneyATM < 0)
                    {
                        moneyATM = 0;
                    }

                }else if(action == "save")
                {
                    countDaysWithSpending = 0;
                    moneyATM += currentSum;
                }
                countDays++;
            }
            if(countDaysWithSpending == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{countDays}");
            }
            else
            {
                Console.WriteLine($"You saved the money for {countDays} days.");
            }






        }
    }
}
