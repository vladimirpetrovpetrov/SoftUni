using System;

namespace Bigger_than_neighbours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indexOfANum = 2;
            int[] numbers = { 1, 2, 6, 4, 5, 6 };
            //Console.WriteLine(IsBiggerThanNeighbours(indexOfANum,numbers));
            IsBiggerThanNeighbours(indexOfANum, numbers);
        }
        /// <summary>
        /// Check if a number with this index is bigger than his left and his right neighbour number in array.
        /// </summary>
        /// <param name="index_of_number">The index of the number you want to check.</param>
        /// <param name="arr">The array.</param>
        /// <returns></returns>
        static bool IsBiggerThanNeighbours(int index_of_number, int[] arr)
        {
            if (arr[index_of_number] > arr[index_of_number - 1] &&
                arr[index_of_number] > arr[index_of_number + 1])
            {
                return true;
            }
            else { return false; }
        }
    }
}
