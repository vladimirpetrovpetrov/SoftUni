using System;
using System.Linq;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {


            
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var count = 0;
            var sumEven = 0;
            var sumOdd = 0;
            for (int i = num1; i <= num2; i++)
            {
                var num = i;
                while (num > 0)
                {
                    sumEven += num % 10;
                    num /= 10;
                    sumOdd += num % 10;
                    num /= 10;
                }
                if (sumEven == sumOdd)
                {
                    count++;
                    Console.Write(i+" ");
                    
                }
                sumEven = 0;
                sumOdd = 0;
            }
            
            
        }
       
    }
}
