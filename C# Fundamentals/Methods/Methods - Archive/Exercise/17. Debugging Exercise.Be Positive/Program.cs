using System;
using System.Collections.Generic;
using System.Linq;

public class BePositive_broken
{
    public static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            var input = Console.ReadLine().Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> newInput = new List<int>();

            for (int j = 0; j < input.Count; j++)
            {
                if (input[j] >= 0)
                {
                    newInput.Add(input[j]);
                }
                else
                {
                    if (j != input.Count - 1)
                    {
                        int test = input[j] + input[j + 1];
                        if (test >= 0)
                        {
                            newInput.Add(test);
                        }
                        j++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            if (newInput.Count == 0)
            {
                Console.WriteLine("(empty)");
            }
            else
            {
                Console.WriteLine(String.Join(" ", newInput));
            }
        }
    }
}

//using System;
//using System.Collections.Generic;

//public class BePositive_broken
//{
//    public static void Main()
//    {
//        int countSequences = int.Parse(Console.ReadLine());

//        for (int i = 0; i < countSequences; i++)
//        {
//            string[] input = Console.ReadLine().Trim().Split(' ');
//            var numbers = new List<int>();

//            for (int j = 0; j < input.Length; j++)
//            {
//                if (!input[j].Equals(string.Empty))
//                {
//                    int num = int.Parse(input[i]);
//                    numbers.Add(num);
//                }
//            }

//            bool found = false;

//            for (int j = 0; j < numbers.Count; j++)
//            {
//                int currentNum = numbers[j];

//                if (currentNum > 0)
//                {
//                    if (found)
//                    {
//                        Console.Write(" ");
//                    }

//                    Console.Write(currentNum);

//                    found = true;
//                }
//                else
//                {
//                    currentNum += numbers[j + 1];

//                    if (currentNum > 0)
//                    {
//                        if (found)
//                        {
//                            Console.Write(" ");
//                        }

//                        Console.Write(currentNum);

//                        found = true;
//                    }
//                }
//            }

//            if (!found)
//            {
//                Console.WriteLine("(empty)");
//            }
//        }
//    }
//}