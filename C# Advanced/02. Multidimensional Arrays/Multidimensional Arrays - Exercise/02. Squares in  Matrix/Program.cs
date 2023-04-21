var sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
var rows = sizes[0];
var cols = sizes[1];
var matrix = new char[rows, cols];
for (int row = 0; row < rows; row++)
{
    var rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = rowData[col];
    }
}
int count = 0;
for (int row = 0; row < rows - 1; row++)
{
    for (int col = 0; col < cols - 1; col++)
    {
        if (matrix[row, col] == matrix[row, col + 1] &&
            matrix[row, col + 1] == matrix[row + 1, col] &&
            matrix[row + 1, col] == matrix[row + 1, col + 1]
            )
        {
            count++;
        }
    }
}
Console.WriteLine(count);