using System.Data;

var n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];
for (int row = 0; row < matrix.GetLength(0); row++)
{
    var rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = rowData[col];
    }
}
// [0,0]
// [1,1]
// [2,2]
var diagonalSum = 0;
for (int i = 0; i < n; i++)
{
    diagonalSum += matrix[i, i];
}
Console.WriteLine(diagonalSum);