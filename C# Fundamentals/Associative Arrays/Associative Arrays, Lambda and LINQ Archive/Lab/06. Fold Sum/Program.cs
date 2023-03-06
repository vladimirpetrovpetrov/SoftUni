using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;

namespace _06._Fold_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var lenght = input.Count();
            var mainLength = lenght / 2;
            var littleLength = mainLength / 2;

            List<int> mainArray = new List<int>();
            List<int> leftArray= new List<int>();
            List<int> rightArray= new List<int>();

            mainArray = input.Skip(littleLength).Take(mainLength).ToList();
            leftArray = input.Take(littleLength).Reverse().ToList();
            rightArray = input.Skip(mainLength+littleLength).Reverse().Take(littleLength).ToList();
            leftArray.AddRange(rightArray);
            for (int i = 0; i < mainArray.Count; i++)
            {
                mainArray[i] += leftArray[i];
            }
            Console.WriteLine(String.Join(" ",mainArray));


        }
    }
}
