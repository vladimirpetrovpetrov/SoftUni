using System;
using System.Linq;

namespace Sum_of_numbers___representated_in_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You have two ints , which digits are representated with array and are reversed.
            //You need to reverse them , convert them in ints then sum it, convert them in arrays
            //again and reversed it.
            int[] number1 = { 1, 3, 2, 4 }; //4231
            int[] number2 = { 2, 7, 5, 3 }; //2753


            int sum = ArrayToInt(number1) + ArrayToInt(number2);
            Console.WriteLine(sum);
            var arr = IntToArray(sum);
            Console.WriteLine(String.Join(',', arr)); //7803
            var arr1 = IntToArray(sum).Reverse();
            Console.WriteLine(String.Join(',', arr1)); //3087
        }

        private static int ArrayToInt(int[] arr)
        {
            var num1 = "";
            for (int i = 0; i < arr.Length; i++)
            {
                num1 += arr[arr.Length - 1 - i];
            }
            var result = int.Parse(num1);
            return result;
        }
        static int[] IntToArray(int num)
        {
            var sNum = num.ToString();
            int[] result = new int[sNum.Length];
            var i = 0;
            while (num > 0)
            {
                result[sNum.Length - 1 - i] = num % 10;
                num /= 10;
                i++;
            }
            return result;
        }

    }
}
