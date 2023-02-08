using System;

namespace _05._Fibonacci_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           var n = int.Parse(Console.ReadLine());
            Fibonacci(n);
        }
        static void Fibonacci(int n)
        {
            
            if(n == 0)
            {
                Console.WriteLine(1);
                return;
            }else if (n == 1)
            {
                Console.WriteLine(1);
                return;
            }
            long f1 = 1;
            long fNext = 2;
            for (int i = 0; i < n-2; i++)
            {
                long temp = fNext;
                fNext = fNext + f1;
                f1 = temp;
            }
            Console.WriteLine(fNext);
        }
       
    }
}
