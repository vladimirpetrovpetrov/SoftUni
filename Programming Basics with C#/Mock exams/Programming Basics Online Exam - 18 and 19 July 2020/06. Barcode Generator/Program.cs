using System;

namespace _06._Barcode_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var num1Start = FirstDigit(start);
            var num1End = FirstDigit(end);
            var num2Start = SecondDigit(start);
            var num2End = SecondDigit(end);
            var num3Start = ThirdDigit(start);
            var num3End = ThirdDigit(end);  
            var num4Start = LastDigit(start);
            var num4End = LastDigit(end);

            for (int n1 = num1Start; n1 <= num1End; n1++)
            {
                for (int n2 = num2Start; n2 <= num2End; n2++)
                {
                    for (int n3 = num3Start; n3 <= num3End; n3++)
                    {
                        for (int n4 = num4Start; n4 <= num4End; n4++)
                        {
                            if(
                               !(n1%2==0) && !(n2%2==0) &&
                               !(n3%2==0) && !(n4 % 2 == 0)
                               )
                            {
                                Console.Write($"{n1}{n2}{n3}{n4} ");
                            }
                        }
                    }
                }
            }
        }

        public static int LastDigit(int num)
        {
            int result;
            result = num % 10;
            return result;
        }
        public static int FirstDigit(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = num % 10;
                num /= 10;
            }
            return result;
        }
        public static int SecondDigit(int num)
        {
            int result = 0;
            while (num > 10)
            {
                result = num % 10;
                num /= 10;
            }
            return result;
        }
        public static int ThirdDigit(int num)
        {
            int result = 0;
            while (num > 100)
            {
                result = num % 10;
                num /= 10;
            }
            return result;
        }
    }
}
