var n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n,n];
for (int row = 0; row < n; row++)
{
    var rowData = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
	for (int col = 0; col < n; col++)
	{
		matrix[row,col] = rowData[col];
	}
}
var pdiagonal = 0;
for (int row = 0;row<n; row++)
{
	pdiagonal += matrix[row, row];
}
var sdiagonal = 0;
for (int row = 0; row < n; row++)
{
    sdiagonal += matrix[matrix.GetLength(0)-1-row, row];
}
Console.WriteLine(Math.Abs(pdiagonal-sdiagonal));