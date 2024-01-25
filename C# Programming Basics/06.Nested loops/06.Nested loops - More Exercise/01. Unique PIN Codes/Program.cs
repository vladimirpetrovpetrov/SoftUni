using System;

namespace _01._Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var count = 0;

            for (int i = 1; i <= num1; i++)
            {
                for (int j = 1; j <= num2; j++)
                {
                    for (int k = 1; k <= num3; k++)
                    {
                        for (int check = 2; check <= 7; check++)
                        {
                            if (j % check == 0) { count++; }
                        }
                        if((i%2==0 && k%2 ==0) && (j>= 2 && j<=7 && count<=1))
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                        count = 0;
                    }
                }
            }
        }
    }
}
