using System;

namespace Declare_and_Init_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 5 * i;
            }
            Console.WriteLine(String.Join(", ", array));


        }
    }
}
