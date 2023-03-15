using System;
using System.Linq;
using System.Text;

namespace _06._Sum_Big_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstNum = Console.ReadLine();
            var secondNum = Console.ReadLine(); 
            var result = new int[Math.Max(firstNum.Length, secondNum.Length)];
            var leftover = 0;
            //ако са еднакви по дължина
            if (firstNum.Length == secondNum.Length)
            {
                for (int i = result.Length - 1; i >= 0; i--)
                {
                    var sum = int.Parse(firstNum[i].ToString()) + int.Parse(secondNum[i].ToString());
                    if (i == 0)
                    {
                        result[i] = sum + leftover;
                        break;
                    }
                    result[i] = sum % 10 + leftover;
                    leftover = 0;
                    if(sum > 9)
                    {
                        leftover += sum / 10;
                    }
                }
                Console.WriteLine(String.Join("",result));
            }
            else
            {
                bool firstIsBigger = firstNum.Length > secondNum.Length;
               
            }
            //TODO
        }
    }
}
