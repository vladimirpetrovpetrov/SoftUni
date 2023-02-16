using System;
using System.Collections.Generic;
using System.Linq;
//try it with classes and objects
namespace test1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var lengthOfDNA = int.Parse(Console.ReadLine());
            string command = string.Empty;
            List<DNA> list = new List<DNA>();
            while (command != "Clone them!")
            {
                command = Console.ReadLine();
                if (command == "Clone them!")
                {
                    break;
                }

                var arr = command.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                var result = FindMaxSeq(arr);
                int maxSeq = result.Item1;
                int mostLeft = result.Item2;
                int sum = arr.Sum();
                list.Add(new DNA(command, maxSeq, mostLeft, sum));
            }
            Best theBest = FindBestSeq(list);

            Console.WriteLine($"Best DNA sample {theBest.Number} with sum: {theBest.SumOf}.");
            var x = theBest.Name.Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();
            Console.WriteLine(String.Join(" ", x));
        }

        public static Best FindBestSeq(List<DNA> list)
        {
            int bigMax = int.MinValue; ; int leftMax = int.MaxValue; ; int sumMax = int.MinValue; int seqNumber = 0; string name = string.Empty;
            for (int i = 0; i < list.Count; i++)
            {

                if (list[i].Longest > bigMax)
                {

                    bigMax = list[i].Longest;
                    leftMax = list[i].LeftIndex;
                    sumMax = list[i].SumOf;
                    seqNumber = i + 1;
                    name = list[i].Name;

                }
                else if (list[i].Longest == bigMax)
                {
                    if (list[i].LeftIndex < leftMax)
                    {
                        bigMax = list[i].Longest;
                        leftMax = list[i].LeftIndex;
                        sumMax = list[i].SumOf;
                        seqNumber = i + 1;
                        name = list[i].Name;
                    }
                    else if (list[i].LeftIndex == leftMax)
                    {
                        if (list[i].SumOf > sumMax)
                        {
                            bigMax = list[i].Longest;
                            leftMax = list[i].LeftIndex;
                            sumMax = list[i].SumOf;
                            seqNumber = i + 1;
                            name = list[i].Name;
                        }
                    }
                }
            }
            Best theBest = new Best(name, bigMax, leftMax, sumMax, seqNumber);
            return theBest;


        }

        public static (int, int) FindMaxSeq(int[] arr)
        {

            int maxSeq = 0;
            int seqNow = 0;
            int mostLeftIndex = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 1)
                {
                    seqNow = 1;
                    if (seqNow > maxSeq)
                    {
                        maxSeq = seqNow;
                        mostLeftIndex = i;

                    }
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            seqNow++;
                            if (seqNow > maxSeq)
                            {
                                maxSeq = seqNow;
                                mostLeftIndex = i;
                            }
                        }
                        else
                        {
                            seqNow = 0;
                            break;
                        }
                    }
                    seqNow = 0;
                }
            }

            return (maxSeq, mostLeftIndex);
        }
    }
    public class DNA
    {
        public DNA(string name, int longest, int leftIndex, int sumOf)
        {
            Name = name;
            Longest = longest;
            LeftIndex = leftIndex;
            SumOf = sumOf;
        }
        public string Name { get; set; }
        public int Longest { get; set; }
        public int LeftIndex { get; set; }
        public int SumOf
        {
            get; set;
        }
    }
    public class Best
    {
        public Best(string name, int longest, int leftIndex, int sumOf, int number)
        {
            Name = name;
            Longest = longest;
            LeftIndex = leftIndex;
            SumOf = sumOf;
            Number = number;
        }
        public string Name { get; set; }
        public int Longest { get; set; }
        public int LeftIndex { get; set; }
        public int SumOf
        {
            get; set;
        }
        public int Number { get; set; }
    }
}