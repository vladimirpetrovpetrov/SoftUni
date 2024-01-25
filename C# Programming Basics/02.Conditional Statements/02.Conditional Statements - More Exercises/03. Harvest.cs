using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sqM = int.Parse(Console.ReadLine());
            var kgPerSqM = double.Parse(Console.ReadLine());
            var litersForSale = int.Parse(Console.ReadLine());
            var workerCount = int.Parse(Console.ReadLine());

            var usedSqM = sqM * 0.40;
            var totalKg = usedSqM * kgPerSqM;
            var totalLiters = totalKg / 2.5;
            if (totalLiters < litersForSale)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(litersForSale - totalLiters));
            }
            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(totalLiters));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(totalLiters - litersForSale), Math.Ceiling((totalLiters - litersForSale) / workerCount));
            }


        }
    }
}
