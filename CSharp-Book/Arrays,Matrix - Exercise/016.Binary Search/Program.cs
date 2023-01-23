using System;
using System.ComponentModel.DataAnnotations;

public class SamplesArray
{
    public static void Main()
    {
        int[] ints = { 9, 2, 3,2 };
        var n1 = 3;
        var n2 = 5;
        FindTheNum(ints, n1);
        FindTheNum(ints, n2);
    }

    public static void FindTheNum(int[] arr, int a)
    {
        //sort and print againt
        Array.Sort(arr);
        PrintArray(arr);
        var result = Array.BinarySearch(arr, a);
        if (result < 0)
        {
            Console.WriteLine($"Cannot find {a}");
        }
        else
        {
            Console.WriteLine($"{a} is at {result} index.");
        }
    }

    public static void PrintArray(int[] arr)
    {
        Console.WriteLine(String.Join(", ",arr));
    }
   
}

