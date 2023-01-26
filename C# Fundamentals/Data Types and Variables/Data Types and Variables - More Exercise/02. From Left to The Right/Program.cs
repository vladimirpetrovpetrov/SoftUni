using System.Collections.Generic;


var number = int.Parse(Console.ReadLine());
var result = 0l;
for (int i = 0; i < number; i++)
{
    long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();
    if (arr[0] >= arr[1])
    {
        long digits = arr[0];

        while (digits != 0)
        {
            long currDigit = digits % 10;

            result += currDigit;

            digits /= 10;
        }
        Console.WriteLine(Math.Abs(result));
    }

    else
    {
        long digits = arr[1];

        while (digits != 0)
        {
            long currDigit = digits % 10;

            result += currDigit;

            digits /= 10;
        }
        Console.WriteLine(Math.Abs(result));
    }
    result = 0;
}



long SumDigits(long a)
{
    long sum = 0;
    while(a>0) 
    {
        sum += a % 10;
        a /= 10;
    }
    return Math.Abs(sum);
}