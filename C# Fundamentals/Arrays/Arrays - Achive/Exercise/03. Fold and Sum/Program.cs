using System;
using System.Linq;

namespace _3._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();


            int j = 0;

            int[] firstRowLeft = new int[arr.Length / 4];
            int[] firstRowRight = new int[arr.Length / 4];
            for (int i = 0; i < firstRowLeft.Length; i++)
            {
                firstRowLeft[i] = arr[i];
            }
            for (int i = arr.Length - 1; i >= arr.Length - firstRowRight.Length; i--)
            {
                firstRowRight[firstRowRight.Length - 1 - j] = arr[i];
                j++;
            }
            j = 0;
            int temp = 0;
            //завъртаме лявата поливинка
            for (int i = 0; i < firstRowLeft.Length / 2; i++)
            {
                temp = firstRowLeft[i];
                firstRowLeft[i] = firstRowLeft[firstRowLeft.Length - i - 1];
                firstRowLeft[firstRowLeft.Length - i - 1] = temp;
            }
            //завъртаме дясната поливинка
            for (int i = 0; i < firstRowRight.Length / 2; i++)
            {
                temp = firstRowRight[i];
                firstRowRight[i] = firstRowRight[firstRowRight.Length - i - 1];
                firstRowRight[firstRowRight.Length - i - 1] = temp;
            }
            int[] firstRow = new int[arr.Length / 2];
            for (int i = 0; i < firstRowLeft.Length; i++)
            {
                firstRow[i] = firstRowLeft[i];
            }
            for (int i = firstRow.Length - firstRowRight.Length; i < firstRow.Length; i++)
            {
                firstRow[i] = firstRowRight[j];
                j++;
            }
            int[] secondRow = new int[arr.Length / 2];
            Array.Copy(arr, firstRowLeft.Length, secondRow, 0, secondRow.Length);
            for (int i = 0; i < secondRow.Length; i++)
            {
                firstRow[i] += secondRow[i];
            }
            Console.WriteLine(String.Join(" ", firstRow));

        }
    }
}
