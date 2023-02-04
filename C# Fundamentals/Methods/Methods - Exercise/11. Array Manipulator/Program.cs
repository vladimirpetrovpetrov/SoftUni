using System.Data;

var array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
while (true)
{
    var command = Console.ReadLine();
    if (command == "end")
    {
        if (array.Length == 1)
        {
            Console.WriteLine("[" + String.Join(" ", array) + "]");
        }
        else
        {
            Console.WriteLine("[" + String.Join(", ", array) + "]");
        }
        return;
    }//ends the program
    var splittedCommand = command.Split().ToArray();
    if (splittedCommand[0] == "exchange")
    {
        int num = int.Parse(splittedCommand[1]);
        array = ExachangeIndex(array, num);
    }
    else if (splittedCommand[0] == "max")
    {
        if (splittedCommand[1] == "even")
        {
            MaxEven(array);
        }
        else
        {
            MaxOdd(array);
        }
    }
    else if (splittedCommand[0] == "min")
    {
        if (splittedCommand[1] == "even")
        {
            MinEven(array);
        }
        else
        {
            MinOdd(array);
        }
    }
    else if (splittedCommand[0] == "first")
    {
        if (splittedCommand[2] == "even")
        {
            int num = int.Parse(splittedCommand[1]);
            FirstEven(array, num);
        }
        else
        {
            int num = int.Parse(splittedCommand[1]);
            FirstOdd(array, num);
        }
    }
    else if (splittedCommand[0] == "last")
    {
        if (splittedCommand[2] == "even")
        {
            int num = int.Parse(splittedCommand[1]);
            LastEven(array, num);
        }
        else
        {
            int num = int.Parse(splittedCommand[1]);
            LastOdd(array, num);
        }
    }
}
static void FirstEven(int[] x, int num)
{
    if (num > x.Length)
    {
        Console.WriteLine("Invalid count");
        return;
    }
    int[] y = new int[num];
    int count = 0;
    int k = 0;
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] % 2 == 0)
        {
            y[k] = x[i];
            count++;
            k++;
            if (count == num)
            {
                break;
            }
        }
    }
    k = 0;
    if (count == 0)
    {
        Console.WriteLine("[]");
        return;
    }
    if (count < num)
    {
        int[] z = new int[count];
        Array.Copy(y, z, count);
        Console.WriteLine("[" + String.Join(", ", z) + "]");
    }
    else
    {
        if (y.Length == 1)
        {
            Console.WriteLine("[" + String.Join(" ", y) + "]");
        }
        else
        {
            Console.WriteLine("[" + String.Join(", ", y) + "]");
        }
    }

}
static void FirstOdd(int[] x, int num)
{
    if (num > x.Length)
    {
        Console.WriteLine("Invalid count");
        return;
    }
    int[] y = new int[num];
    int count = 0;
    int k = 0;
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] % 2 != 0)
        {
            y[k] = x[i];
            count++;
            k++;
            if (count == num)
            {
                break;
            }
        }
    }
    k = 0;
    if (count == 0)
    {
        Console.WriteLine("[]");
        return;
    }//ako mine gornata proverka no e 1 counta
    if (count < num)
    {
        int[] z = new int[count];
        Array.Copy(y, z, count);
        Console.WriteLine("[" + String.Join(", ", z) + "]");
    }
    else
    {
        if (y.Length == 1)
        {
            Console.WriteLine("[" + String.Join(" ", y) + "]");
        }
        else
        {
            Console.WriteLine("[" + String.Join(", ", y) + "]");
        }
    }

}
static void LastOdd(int[] x, int num)
{
    if (num > x.Length)
    {
        Console.WriteLine("Invalid count");
        return;
    }
    int[] y = new int[num];
    int count = 0;
    int k = y.Length - 1;
    for (int i = x.Length - 1; i >= 0; i--)
    {
        if (x[i] % 2 != 0)
        {
            y[k] = x[i];
            count++;
            k--;
            if (count == num)
            {
                break;
            }
        }
    }
    k = 0;
    if (count == 0)
    {
        Console.WriteLine("[]");
        return;
    }
    if (count < num)
    {
        int[] z = new int[count];
        Array.Copy(y, y.Length - count, z, 0, count);
        Console.WriteLine("[" + String.Join(", ", z) + "]");
    }
    else
    {
        if (y.Length == 1)
        {
            Console.WriteLine("[" + String.Join(" ", y) + "]");
        }
        else
        {
            Console.WriteLine("[" + String.Join(", ", y) + "]");
        }
    }

}
static void LastEven(int[] x, int num)
{
    if (num > x.Length)
    {
        Console.WriteLine("Invalid count");
        return;
    }
    int[] y = new int[num];
    int count = 0;
    int k = y.Length - 1;
    for (int i = x.Length - 1; i >= 0; i--)
    {
        if (x[i] % 2 == 0)
        {
            y[k] = x[i];
            count++;
            k--;
            if (count == num)
            {
                break;
            }
        }
    }
    k = 0;
    if (count == 0)
    {
        Console.WriteLine("[]");
        return;
    }
    if (count < num)
    {
        int[] z = new int[count];
        Array.Copy(y, z, count);
        Console.WriteLine("[" + String.Join(", ", z) + "]");
    }
    else
    {
        if (y.Length == 1)
        {
            Console.WriteLine("[" + String.Join(" ", y) + "]");
        }
        else
        {
            Console.WriteLine("[" + String.Join(", ", y) + "]");
        }
    }

}
static void MinEven(int[] x)
{
    int minEven = int.MaxValue;
    int minIndex = 0;
    int count = 0;
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] <= minEven && x[i] % 2 == 0)
        {
            count++;
            minEven = x[i];
            minIndex = i;
        }
    }
    if (count == 0)
    {
        Console.WriteLine("No matches");
    }
    else
    {
        Console.WriteLine(minIndex);
    }
}
static void MinOdd(int[] x)
{
    int minOdd = int.MaxValue;
    int minIndex = 0;
    int count = 0;
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] <= minOdd && x[i] % 2 != 0)
        {
            count++;
            minOdd = x[i];
            minIndex = i;
        }
    }
    if (count == 0)
    {
        Console.WriteLine("No matches");
    }
    else
    {
        Console.WriteLine(minIndex);
    }
}
static void MaxEven(int[] x)
{
    int maxEven = int.MinValue;
    int maxIndex = 0;
    int count = 0;
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] >= maxEven && x[i] % 2 == 0)
        {
            count++;
            maxEven = x[i];
            maxIndex = i;
        }
    }
    if (count == 0)
    {
        Console.WriteLine("No matches");
    }
    else
    {
        Console.WriteLine(maxIndex);
    }
}
static void MaxOdd(int[] x)
{
    int maxOdd = int.MinValue;
    int maxIndex = 0;
    int count = 0;
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] >= maxOdd && x[i] % 2 != 0)
        {
            count++;
            maxOdd = x[i];
            maxIndex = i;
        }
    }
    if (count == 0)
    {
        Console.WriteLine("No matches");
    }
    else
    {
        Console.WriteLine(maxIndex);
    }
}
static int[] ExachangeIndex(int[] x, int num)
{
    if (num < 0 || num > x.Length - 1)
    {
        Console.WriteLine("Invalid index");
        return x;
    }
    int[] rightArr = new int[x.Length - (num + 1)];
    int[] leftArr = new int[x.Length - rightArr.Length];
    int[] finalArr = new int[x.Length];
    int k = 0;
    for (int i = 0; i < leftArr.Length; i++)
    {
        leftArr[i] = x[i];
    }
    for (int i = leftArr.Length; i < x.Length; i++)
    {
        rightArr[k] = x[i];
        k++;
    }

    Array.Copy(rightArr, finalArr, rightArr.Length);
    Array.Copy(leftArr, 0, finalArr, rightArr.Length, leftArr.Length);
    return finalArr;
} //exchange function