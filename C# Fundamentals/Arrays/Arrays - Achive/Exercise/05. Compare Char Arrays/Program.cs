using System;
using System.Linq;

namespace _05._Compare_Char_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {


            char[] arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            bool firstIsBigger = false;
            bool secondIsBigger = false;
            int length = Math.Min(arr1.Length, arr2.Length);

            for (int i = 0; i < length; i++)
            {
                
                    if (arr1[i] < arr2[i])
                    {
                        firstIsBigger = true;
                        break;
                    }
                    else if (arr1[i] > arr2[i])
                    {
                        secondIsBigger = true;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                
            }
            if(!firstIsBigger && !secondIsBigger && arr1.Length == arr2.Length)
            {
                Console.WriteLine(String.Join("",arr1));
                Console.WriteLine(String.Join("", arr2));
            }else if(!firstIsBigger && !secondIsBigger && !(arr1.Length == arr2.Length))
            {
                if(arr1.Length > arr2.Length) 
                {
                    Console.WriteLine(String.Join("", arr2));
                    Console.WriteLine(String.Join("", arr1));
                }
                else
                {
                    Console.WriteLine(String.Join("", arr1));
                    Console.WriteLine(String.Join("", arr2));
                }
            }
            else
            {
                if(firstIsBigger)
                {
                    Console.WriteLine(String.Join("", arr1));
                    Console.WriteLine(String.Join("", arr2));
                    

                }else if (secondIsBigger)
                {
                    Console.WriteLine(String.Join("", arr2));
                    Console.WriteLine(String.Join("", arr1));
                }
            }



        }
    }
}
