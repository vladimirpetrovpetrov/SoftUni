using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Most_Frequent__Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intsM = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
           
            if(intsM.Length == 1)
            {
                Console.WriteLine(intsM[0]);
                return;
            }

            HashSet<int> numbers = new HashSet<int>();
            for (int i = 0; i < intsM.Length; i++)
            {
                numbers.Add(intsM[i]);
            }
            List<int> list = numbers.ToList();
            int maxSeq = 1;
            int bestNum = int.MaxValue;
            for (int i = 0; i < list.Count; i++)
            {
                int sNow = 1;
                int numNow = list[i];
                
                for (int j = 0; j < intsM.Length; j++)
                {
                    if (list[i] == intsM[j])
                    {
                        sNow++;
                        if (sNow > maxSeq)
                        {
                            maxSeq = sNow;
                            bestNum = numNow;
                        }
                    }
                }
            }
            Console.WriteLine(bestNum);
        }
    }
}
