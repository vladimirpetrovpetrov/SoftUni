using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main()
        {
            var list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string longestNum = string.Empty;
            int longestCount = 1;
            int countNow = 1;
            int lastIndex = 0;


            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        countNow++;
                        if (countNow > longestCount)
                        {
                            longestCount = countNow;
                            longestNum = list[i];
                        }
                    }
                    else
                    {
                        countNow = 1;
                        break;
                    }
                }
                countNow = 1;
            }
            if (longestCount == 1)
            {
                Console.WriteLine(list[0]);
                return;
            }

            List<string> results = new List<string>();
            for (int i = 0; i < longestCount; i++)
            {
                results.Add(longestNum);
            }
            Console.WriteLine(String.Join(" ", results));
        }
    }
}
