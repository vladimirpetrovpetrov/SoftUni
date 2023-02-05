using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Max_Sequence_of_Increasing_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            List<int> bestList = new List<int>();
            int sMax = 1;
            for (int i = 0; i < ints.Length - 1; i++)
            {
                List<int> nowList = new List<int>();
                int sNow = 1;
                nowList.Add(ints[i]);
                for (int j = i; j < ints.Length - 1; j++)
                {
                    if (ints[j] < ints[j + 1])
                    {
                        sNow++;
                        nowList.Add(ints[j+1]);
                        if (sNow > sMax)
                        {
                            bestList = nowList;
                            sMax = sNow;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(String.Join(" ",bestList));
        }
    }
}
