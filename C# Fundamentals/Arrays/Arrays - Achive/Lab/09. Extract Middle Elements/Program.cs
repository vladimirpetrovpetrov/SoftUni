using System;

namespace _09._Extract_Middle_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split();
            int length = 0;
            if(arr.Length == 1 )
            {
                Console.WriteLine($"{{ {arr[0]} }}");
            }
            else if (arr.Length % 2 == 0)
            {
                length = arr.Length / 2 -1;
                Console.WriteLine($"{{ {arr[length]}, {arr[length + 1]} }}");




            }else if (arr.Length % 2 != 0)
            {

                length = arr.Length / 2 - 1;
                Console.WriteLine($"{{{arr[length]}, {arr[length+1]}, {arr[length+2]}}}");



            }











        }
    }
}
