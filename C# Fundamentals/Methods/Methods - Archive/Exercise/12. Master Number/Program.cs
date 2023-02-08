using System;

namespace _12._Master_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Check(i);

            }

        }
        static void Check(int num)
        {
            if(Palindrome(num.ToString()) && DivisibleBySeven(num) && HaveEvenDigit(num.ToString()))
            {
                Console.WriteLine(num);
            }
        }
        static bool Palindrome(string s)
        {
            bool isItP = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[s.Length- 1-i])
                {
                    isItP = false;
                    break;
                }
            }
            return isItP;
        }
        static bool DivisibleBySeven(int s)
        {
            bool isItP = false;
            int sum = 0;
            while (s > 0)
            {
                sum += s % 10;
                s /= 10;
            }
            if (sum % 7 == 0)
            {
                isItP = true;
            }
            return isItP;
        }
        static bool HaveEvenDigit(string s)
        {
            bool isItP = false;
            int sInt = int.Parse(s);
            while(sInt>0)
            {
                int lastDigit = sInt % 10;
                if (lastDigit % 2 == 0)
                {
                    isItP= true;
                    break;
                }
                sInt /= 10;
            }
            return isItP;
        }
    }
}
