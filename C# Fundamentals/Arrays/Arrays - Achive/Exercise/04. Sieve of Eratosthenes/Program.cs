using System;

namespace _4._Sieve_of_Eratosthenes
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var n = int.Parse(Console.ReadLine());
            if (n == 1 || n==0)
            {
                return;
            }
            //1.Съзадаваме масив от булеани със дължина н+1 защото е ] и го инициализираме само с true
            bool[] prime = new bool[n+1]; //create a bool []
            for (int i = 0; i < prime.Length; i++)
            {
                prime[i] = true; // make all elements true
            }
            //2.Алгоритъм за зачеркване на всички които не са труе

            for (int p = 2; p*p <= n; p++) 
            {
                if (prime[p]) 
                {
                    for (int i = p*p; i <=n; i+=p)
                    {
                        prime[i] = false;
                    }
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (prime[i] == true)
                    Console.Write(i + " ");
            }


        }
    }
}
