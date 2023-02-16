using System;

namespace _01._Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int days = int.Parse(Console.ReadLine());
            double perDay = double.Parse(Console.ReadLine());
            double expected = double.Parse(Console.ReadLine());
            double totalP = 0;
            for (int i = 1; i <= days; i++)
            {
                totalP+= perDay;
                
                if (i % 3 == 0)
                {
                    totalP += perDay*0.5;
                }
                if(i % 5 == 0)
                {
                    totalP *= 0.70;
                }
            }
            if(totalP>=expected)
            {
                Console.WriteLine($"Ahoy! {totalP:f2} plunder gained.");
            }
            else
            {
                double percentage = (totalP * 100) / expected;
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
        }
    }
}
