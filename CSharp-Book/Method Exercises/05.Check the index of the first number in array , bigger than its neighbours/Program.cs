using System;

namespace Check_the_index_of_the_first_number_in_array___bigger_than_its_neighbours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 1, 4, 5, 6, 7, 8, 9, 10, 2, 3, 41, 2, 3 };
            Console.WriteLine(IndexOfNum(numbers));
        }
        /// <summary>
        /// Returns the index of the first num in array, which is bigger than his neighbours.
        /// </summary>
        /// <param name="arr">Array</param>
        /// <returns></returns>
        static int IndexOfNum(int[] arr)
        {
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i - 1] < arr[i] && arr[i + 1] < arr[i])
                {
                    return i;
                }
            }
            return -1;
        }




    }
}
