var sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
var snakeName = Console.ReadLine();
var rows = sizes[0];
var cols = sizes[1];
var matrix = new char[rows, cols];
var stringINdex = 0;


for (int row = 0; row < rows; row++)
{
	if (row % 2 == 0)
	{
		for (int col = 0; col < cols; col++)
		{
			matrix[row, col] = snakeName[stringINdex++];
			if(stringINdex > snakeName.Length - 1)
			{
				stringINdex = 0;
			}
		}
	}
	else
	{
        for (int col = cols-1; col >= 0; col--)
        {
            matrix[row, col] = snakeName[stringINdex++];
            if (stringINdex > snakeName.Length - 1)
            {
                stringINdex = 0;
            }
        }
    }
}
PrintMatrix(matrix);
static void PrintMatrix(char[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col]);
        }
        Console.WriteLine();
    }
}