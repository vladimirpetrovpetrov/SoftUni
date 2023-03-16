using System;
using System.Linq;
using System.Text;

namespace _07._Multiply_big_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input.Length > 1)
            {
                input = input.TrimStart('0');
            }
            var theBigNumber = input!.ToCharArray();
            var readyToWork = theBigNumber.Select(x => x.ToString()).ToArray().Select(int.Parse).ToArray();
            var smallerNum = Console.ReadLine();
            if (smallerNum.Length > 1)
            {
                smallerNum = smallerNum.TrimStart('0');
            }
            var n = int.Parse(smallerNum);
            if (n == 0 || input == "0")
            {
                Console.WriteLine(0);
                return;
            }
            StringBuilder st = new StringBuilder();
            var leftOver = 0;
            for (int i = readyToWork.Length - 1; i >= 0; i--)
            {

                var sum = readyToWork[i] * n + leftOver;
                var numberToAdd = sum % 10;
                leftOver = sum / 10;
                if (i == 0)
                {
                    var reversedLastSum = sum.ToString().Reverse().ToArray();
                    var finalSum = new string(reversedLastSum);
                    st.Append(finalSum);
                    break;
                }
                st.Append(numberToAdd);

            }
            var result = st.ToString().Reverse();
            Console.WriteLine(String.Join("", result));
        }
    }
}
