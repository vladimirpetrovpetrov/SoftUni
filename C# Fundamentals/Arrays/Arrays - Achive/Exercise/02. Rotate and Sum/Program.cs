using System;
using System.Linq;
using System.Net.Sockets;

namespace _02._Rotate_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var rotations = int.Parse(Console.ReadLine());

            long[] newLarray = new long[1];
            long[] newRarray = new long[array.Length-1];
            long[] newFullArray = new long[array.Length];
            long[] sum = new long[array.Length];    
            for (int j = 0; j < rotations; j++)
            {
                newLarray[0] = array[array.Length - 1];
                for (int i = 0; i < newRarray.Length; i++)
                {
                    newRarray[i] = array[i];
                }
                Array.Copy(newLarray, newFullArray, newLarray.Length);
                Array.Copy(newRarray, 0, newFullArray, 1, newRarray.Length);
                for (int k = 0; k < sum.Length; k++)
                {
                    sum[k] += newFullArray[k];
                }
                array = newFullArray;
            }

            Console.WriteLine(String.Join(" ", sum));


        }
    }
}
