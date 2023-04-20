var n = int.Parse(Console.ReadLine());
char[,] matrix = new char[n, n];
for (int row = 0; row < matrix.GetLength(0); row++)
{
    var rowData = Console.ReadLine().ToCharArray();
	for (int col = 0; col < n; col++)
	{
		matrix[row, col] = rowData[col];
	}
}
var symbol = char.Parse(Console.ReadLine());
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < n; col++)
    {
        if (matrix[row, col] == symbol) 
        {
            Console.WriteLine($"({row}, {col})");
            return;
        }
    }
}
Console.WriteLine($"{symbol} does not occur in the matrix ");