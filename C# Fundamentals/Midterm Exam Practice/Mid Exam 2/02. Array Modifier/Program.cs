using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => BigInteger.Parse(x)).ToList();

            while(true) 
            {
                var command = Console.ReadLine();
                if(command == "end")
                {
                    break;
                }
                var x = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (x[0] == "swap")
                {
                    SwapIndexes(nums, x);
                }else if (x[0] == "multiply")
                {
                    MultiplyIndexes(nums, x);
                }else if (x[0] == "decrease")
                {
                    DecreaseByOne(nums);
                }
            }
            Console.WriteLine(String.Join(", ",nums));
        }

        private static void DecreaseByOne(List<BigInteger> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                nums[i] -= 1;
            }
        }

        private static void MultiplyIndexes(List<BigInteger> nums, string[] x)
        {
            var index1 = int.Parse(x[1]);
            var index2 = int.Parse(x[2]);

            nums[index1] = nums[index1] * nums[index2];
        }

        private static void SwapIndexes(List<BigInteger> nums, string[] x)
        {
            var index1 = int.Parse(x[1]);
            var index2 = int.Parse(x[2]);
            BigInteger temp = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = temp;
        }
    }
}
