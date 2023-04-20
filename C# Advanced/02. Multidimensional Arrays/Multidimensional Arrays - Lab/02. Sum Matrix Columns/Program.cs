var rowsCols = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
var rows = rowsCols[0];
var cols = rowsCols[1];
int[,] matrix = new int[rows,cols];

for (int row = 0; row < matrix.GetLength(0); row++)
{
	var rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
	for (int col = 0; col < matrix.GetLength(1); col++)
	{
		matrix[row, col] = rowData[col];
	}
}
for (int col = 0; col < matrix.GetLength(1); col++)
{
    var sum = 0;
    for (int row = 0; row < matrix.GetLength(0); row++)
	{
		sum += matrix[row, col];
	}
    Console.WriteLine(sum);
}
