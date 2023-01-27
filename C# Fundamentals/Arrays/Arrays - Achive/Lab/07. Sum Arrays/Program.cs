using System;
using System.Linq;

namespace _07._Sum_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = 0;
            int j = 0;
            bool diff = false;
            if (arr1.Length != arr2.Length)
            {
                length = Math.Max(arr1.Length, arr2.Length);
                diff = true;
            }
            else
            {
                length = arr2.Length;
            }
            int[] arr3 = new int[length];


            if (diff)
            {
                if (arr1.Length < arr2.Length)
                {
                    SumArrays(arr3, arr1);
                    for (int i = 0; i < Math.Abs(arr1.Length - arr2.Length); i++)
                    {
                        arr3[arr1.Length + i] = arr1[j];
                        j++;
                        if (j > arr1.Length - 1)
                        {
                            j = 0;
                        }
                    }
                    for (int i = 0; i < length; i++)
                    {
                        arr3[i] = arr2[i] + arr3[i];
                    }
                    Console.WriteLine(String.Join(" ", arr3));

                }
                else
                {
                    SumArrays(arr3, arr2);
                    for (int i = 0; i < Math.Abs(arr1.Length - arr2.Length); i++)
                    {
                        arr3[arr2.Length + i] = arr2[j];
                        j++;
                        if (j > arr2.Length - 1)
                        {
                            j = 0;
                        }
                    }
                    for (int i = 0; i < length; i++)
                    {
                        arr3[i] = arr1[i] + arr3[i];
                    }
                    Console.WriteLine(String.Join(" ", arr3));
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    arr3[i] = arr2[i] + arr1[i];
                }
                Console.WriteLine(String.Join(" ", arr3));
            }
            


        }
        static void SumArrays(int[] biggerArr, int[] smallerArr)
        {
            int length = Math.Min(biggerArr.Length, smallerArr.Length);
            for (int i = 0; i < length; i++)
            {
                biggerArr[i] = biggerArr[i] + smallerArr[i];
            }

        }
    }
}
