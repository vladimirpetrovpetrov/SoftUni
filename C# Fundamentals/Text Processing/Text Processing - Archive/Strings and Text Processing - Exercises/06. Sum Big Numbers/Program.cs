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
            firstNum= firstNum.TrimStart('0');
            var secondNum = Console.ReadLine(); 
            secondNum = secondNum.TrimStart('0');
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
                var secondNumArray = secondNum.ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();
                var firstNumArray = firstNum.ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();
                int[] smallerNum = new int[Math.Max(firstNum.Length,secondNum.Length)];
                int j = 0;
                if (firstIsBigger)
                {
                    for (int i = smallerNum.Length - 1; i >= 0; i--)
                    {
                        if (secondNumArray.Length - 1 - j >= 0)
                        {
                            smallerNum[i] = secondNumArray[secondNumArray.Length - 1 - j];
                        }
                        else
                        {
                            break;
                        }
                        j++;
                    }
                    for (int i = firstNumArray.Length-1; i >= 0; i--)
                    {
                        if(i == 0)
                        {
                            result[i] = firstNumArray[i] + smallerNum[i] + leftover;
                            break;
                        }
                        var temp = firstNumArray[i] + smallerNum[i] + leftover;
                        leftover = 0;
                        result[i] = temp % 10;
                        if (temp > 9)
                        {
                            leftover += temp / 10;
                        }
                    }
                    Console.WriteLine(String.Join("",result));
                }
                else
                {
                    for (int i = smallerNum.Length - 1; i >= 0; i--)
                    {
                        if (firstNumArray.Length - 1 - j >= 0)
                        {
                            smallerNum[i] = firstNumArray[firstNumArray.Length - 1 - j];
                        }
                        else
                        {
                            break;
                        }
                        j++;
                    }
                    for (int i = secondNumArray.Length - 1; i >= 0; i--)
                    {
                        if (i == 0)
                        {
                            result[i] = secondNumArray[i] + smallerNum[i] + leftover;
                            break;
                        }
                        var temp = secondNumArray[i] + smallerNum[i] + leftover;
                        leftover = 0;
                        result[i] = temp % 10;
                        if (temp > 9)
                        {
                            leftover += temp / 10;
                        }
                    }
                    Console.WriteLine(String.Join("", result));
                }


            }
            
        }

    }
}
