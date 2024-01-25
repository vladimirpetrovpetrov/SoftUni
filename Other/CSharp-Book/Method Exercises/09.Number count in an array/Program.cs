using System;

namespace Count_number_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int searchedNum = 1;
            int[] numbers = new int[] { 1, 2, 1, 2, 4, 1, 6 };
            Console.WriteLine(NumCountInArray(searchedNum, numbers));
        }

        /// <summary>
        /// How many time a number is contained in an array.
        /// </summary>
        /// <param name="number">Searched number</param>
        /// <param name="arr">Array</param>
        /// <returns></returns>
        static int NumCountInArray(int number, int[] arr)
        {
            int count = 0;
            foreach (int i in arr)
            {
                if (i == number)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
