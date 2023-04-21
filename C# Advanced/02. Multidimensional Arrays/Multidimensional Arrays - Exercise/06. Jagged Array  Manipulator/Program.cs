var rows = int.Parse(Console.ReadLine());
var matrix = new double[rows][];

for (int row = 0; row < rows; row++)
{
    var rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
    matrix[row] = rowData;
}

//Analyzing part - If a row and the one below it have equal length, multiply each element in both of them by 2, otherwise - divide by 2.

for (int row = 0; row < rows - 1; row++)
{
    if (matrix[row].Length == matrix[row + 1].Length)
    {
        for (int i = 0; i < matrix[row].Length; i++)
        {
            matrix[row][i] *= 2;
            matrix[row + 1][i] *= 2;
        }
    }
    else
    {
        for (int i = 0; i < matrix[row].Length; i++)
        {
            matrix[row][i] /= 2;
        }
        for (int i = 0; i < matrix[row + 1].Length; i++)
        {
            matrix[row + 1][i] /= 2;
        }
    }
}

while (true)
{
    var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (input[0] == "End")
    {
        break;
    }

    if (input[0] == "Add")
    {
        var row = int.Parse(input[1]);
        var col = int.Parse(input[2]);
        var value = int.Parse(input[3]);
        if (row >= 0 && row < matrix.Length &&
            col >= 0 && col < matrix[row].Length)
        {
            matrix[row][col] += value;
        }
    }
    else if (input[0] == "Subtract")
    {
        var row = int.Parse(input[1]);
        var col = int.Parse(input[2]);
        var value = int.Parse(input[3]);
        if (row >= 0 && row < matrix.Length &&
            col >= 0 && col < matrix[row].Length)
        {
            matrix[row][col] -= value;
        }
    }
}
PrintMatrix(matrix);






static void PrintMatrix(double[][] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix[row].Length; col++)
        {
            Console.Write(matrix[row][col] + " ");
        }
        Console.WriteLine();
    }
}