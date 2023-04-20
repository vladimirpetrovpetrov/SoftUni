var n = int.Parse(Console.ReadLine());
long[][] pascal = new long[n][];

for (int row = 0; row < n; row++)
{
    pascal[row] = new long[row + 1];
    FillArray(pascal[row]);

    for (int col = 1; col < pascal[row].Length - 1; col++)
    {
        var currentSum = pascal[row - 1][col - 1] + pascal[row - 1][col];
        pascal[row][col] = currentSum;
    }
}
for (int i = 0; i < pascal.Length; i++)
{
    Console.WriteLine(String.Join(" ", pascal[i]));
}

static void FillArray(long[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 1;
    }
}