using System;

namespace _1._Largest_Common_End
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split();
            var arr2 = Console.ReadLine().Split();

            int lSeq = 0; int j = 0;
            int rSeq = 0;
            int length = 0;
            bool stopSeq = false;
            //Find which is the bigger array
            if (arr1.Length >= arr2.Length)
            {
                length = arr2.Length;
            }
            else
            {
                length = arr1.Length;
            }
            //Finding if there is a Left seq
            for (int i = 0; i < length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    lSeq++;
                }
                else
                {
                    break;
                }
            }
            //Finding if there is a Right seq
            for (int i = length - 1; i >= 0; i--)
            {
                if (arr1.Length > arr2.Length)
                {
                    if (arr1[arr1.Length - 1 - j] == arr2[i])
                    {
                        j++;
                        rSeq++;
                    }
                    else
                    {
                        stopSeq = true;
                        break;
                    }
                }
                else if (arr1.Length < arr2.Length)
                {
                    if (arr2[arr2.Length - 1 - j] == arr1[i])
                    {
                        j++;
                        rSeq++;
                    }
                    else
                    {
                        stopSeq = true;
                        break;
                    }
                }
                else
                {
                    if (arr2[i] == arr1[i])
                    {
                        
                        rSeq++;
                    }
                    else
                    {
                        stopSeq = true;
                        break;
                    }
                }
                if (stopSeq)
                {
                    break;
                }
            }

            if (lSeq > rSeq)
            {
                Console.WriteLine(lSeq);
            }
            else
            {
                Console.WriteLine(rSeq);
            }
        }
    }
}
