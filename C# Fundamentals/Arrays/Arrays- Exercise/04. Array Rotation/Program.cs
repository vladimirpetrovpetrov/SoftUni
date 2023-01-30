var arr = Console.ReadLine().Split().ToArray();
var rotations = int.Parse(Console.ReadLine()!);
if (arr.Length == rotations)
{
    Console.WriteLine(String.Join(" ", arr));
    return;
}

for (int j = 0;j < rotations; j++)
{
    string temp = arr[0];
    for (int i = 0; i < arr.Length - 1; i++)
    {
        arr[i] = arr[i + 1];
    }
    arr[arr.Length - 1] = temp;
}
Console.WriteLine(String.Join(" ", arr));