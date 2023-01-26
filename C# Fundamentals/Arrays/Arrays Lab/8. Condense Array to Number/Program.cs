var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

for(int i = 0;i < arr.Length-1; i++)
{
    for (int j = 0; j < arr.Length - 1 - i; j++)
    {
        arr[j] = arr[j] + arr[j+1];
    }
}

Console.WriteLine(arr[0]); 