using System;
using System.Linq;
using System.Numerics;

public class SequenceOfCommands_broken
{
    

    public static void Main()
    {
        
        int sizeOfArray = int.Parse(Console.ReadLine());

        BigInteger[] array1 = Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Select(BigInteger.Parse)
            .ToArray();
        BigInteger[] array = new BigInteger[sizeOfArray];
        Array.Copy(array1,0,array,0,sizeOfArray);

        while (true)
        {
            string command = Console.ReadLine();
            if(command == "stop")
            {
                return;
            }
            var toDo = command.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (toDo[0] == "add" || toDo[0] == "subtract" || toDo[0] == "multiply")
            {
                PerformAction(array, toDo[0], int.Parse(toDo[1])-1, int.Parse(toDo[2]));
            }
            else
            {

                PerformAction(array, command);
            }
            Console.WriteLine(String.Join(" ",array));
        }
    }

    static void PerformAction(BigInteger[] arr, string action, int index=0,int number=0)
    {
       if(index< 0 || index > arr.Length-1)
        {
            return;
        }

        switch (action)
        {
            case "multiply":
                arr[index] *= number;

                break;
            case "add":
                arr[index] += number;
                break;
            case "subtract":
                arr[index] -= number;
                break;
            case "lshift":
                ArrayShiftLeft(arr);
                break;
            case "rshift":
                ArrayShiftRight(arr);
                break;
        }
    }

    private static void ArrayShiftRight(BigInteger[] array)
    {
        BigInteger tmp = array[array.Length - 1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = tmp;
    }

    private static void ArrayShiftLeft(BigInteger[] array)
    {
        BigInteger tmp = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = tmp;
    }

    
}

//using System;
//using System.Linq;

//public class SequenceOfCommands_broken
//{
//    private const char ArgumentsDelimiter = ' ';

//    public static void Main()
//    {
//        int sizeOfArray = int.Parse(Console.ReadLine());

//        long[] array = Console.ReadLine()
//            .Split(ArgumentsDelimiter)
//            .Select(long.Parse)
//            .ToArray();

//        string command = Console.ReadLine();

//        while (!command.Equals("over"))
//        {
//            string line = Console.ReadLine().Trim();
//            int[] args = new int[2];

//            if (command.Equals("add") ||
//                command.Equals("substract") ||
//                command.Equals("multiply"))
//            {
//                string[] stringParams = line.Split(ArgumentsDelimiter);
//                args[0] = int.Parse(stringParams[0]);
//                args[1] = int.Parse(stringParams[1]);

//                PerformAction(array, command, args);
//            }

//            PerformAction(array, command, args);

//            PrintArray(array);
//            Console.WriteLine('\n');

//            command = Console.ReadLine();
//        }
//    }

//    static void PerformAction(long[] arr, string action, int[] args)
//    {
//        long[] array = arr.Clone() as long[];
//        int pos = args[0];
//        int value = args[1];

//        switch (action)
//        {
//            case "multiply":
//                array[pos] *= value;
//                break;
//            case "add":
//                array[pos] += value;
//                break;
//            case "subtract":
//                array[pos] -= value;
//                break;
//            case "lshift":
//                ArrayShiftLeft(array);
//                break;
//            case "rshift":
//                ArrayShiftRight(array);
//                break;
//        }
//    }

//    private static void ArrayShiftRight(long[] array)
//    {
//        for (int i = array.Length - 1; i >= 1; i--)
//        {
//            array[i] = array[i - 1];
//        }
//    }

//    private static void ArrayShiftLeft(long[] array)
//    {
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            array[i] = array[i + 1];
//        }
//    }

//    private static void PrintArray(long[] array)
//    {
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.WriteLine(array[i] + " ");
//        }
//    }
//}
