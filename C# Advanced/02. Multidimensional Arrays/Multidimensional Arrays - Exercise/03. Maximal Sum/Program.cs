var sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
var rows = sizes[0];
var cols = sizes[1];
var matrix = new int[rows, cols];
for (int row = 0; row < rows; row++)
{
    var rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowData[col];
    }
}
var startingRow = 0;
var startingColumn = 0;
var maxSum = int.MinValue;


for (int row = 0; row < rows - 2; row++)
{
    
    for (int col = 0; col < cols - 2; col++)
    {
        var currentSum = 0;
        currentSum += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2];
        currentSum += matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2];
        currentSum += matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            startingRow = row;
            startingColumn = col;
        }
    }
}
Console.WriteLine($"Sum = {maxSum}");
for (int row = startingRow; row < startingRow+3; row++)
{
    for (int col = startingColumn; col < startingColumn + 3; col++)
    {
        Console.Write(matrix[row,col]+" ");
    }
    Console.WriteLine();
}