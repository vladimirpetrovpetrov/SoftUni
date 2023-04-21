var sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
var rows = sizes[0];
var cols = sizes[1];
var matrix = new string[rows, cols];
for (int row = 0; row < rows; row++)
{
    var rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowData[col];
    }
}

while (true)
{
    var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (input[0] == "END")
    {
        break;
    }

    if (input[0] != "swap" || input.Length != 5)
    {
        Console.WriteLine("Invalid input!");
        continue;
    }

    var rowOne = int.Parse(input[1]);
    var colOne = int.Parse(input[2]);
    var rowTwo = int.Parse(input[3]);
    var colTwo = int.Parse(input[4]);

    bool coordinates = rowOne >= 0 && rowOne < matrix.GetLength(0) &&
                       rowTwo >= 0 && rowTwo < matrix.GetLength(0) &&
                       colOne >= 0 && colOne < matrix.GetLength(1) &&
                       colTwo >= 0 && colTwo < matrix.GetLength(1);
    if (!coordinates)
    {
        Console.WriteLine("Invalid input!");
        continue;
    }
    var temp = string.Empty;
    temp = matrix[rowOne, colOne];
    matrix[rowOne, colOne] = matrix[rowTwo, colTwo];
    matrix[rowTwo, colTwo] = temp;
    PrintMatrix(matrix);
}



static void PrintMatrix(string[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col] + " ");
        }
        Console.WriteLine();
    }
}