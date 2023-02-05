using System;
using System.Linq;

namespace _06._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxS = 1;
            int seqN = 1;
            int number = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = i + 1; j < ints.Length; j++)
                {
                    if (ints[i] == ints[j])
                    {
                        seqN++;
                        if (seqN > maxS)
                        {
                            maxS = seqN;
                            number = ints[i];
                        }
                    }
                    else
                    {
                        seqN = 1;
                        break;
                    }
                }
                seqN = 1;
            }
            for (int i = 0; i < maxS; i++)
            {
                Console.Write(number + " ");
            }
        }
    }
}
