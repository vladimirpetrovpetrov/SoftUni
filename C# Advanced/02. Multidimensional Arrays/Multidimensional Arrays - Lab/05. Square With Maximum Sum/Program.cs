var sizes = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = sizes[0];
int cols = sizes[1];
int[,] matrix = new int[rows, cols];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    var rowData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = rowData[col];
    }
}
var n1 = 0;
var n2 = 0;
var n3 = 0;
var n4 = 0;
var bestSum = int.MinValue;
for (int row = 0; row < matrix.GetLength(0)-1; row++)
{
    for (int col = 0; col < matrix.GetLength(1) -1; col++)
    {
        var currentSum = 0;
        currentSum += matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
        if (currentSum > bestSum)
        {
            bestSum = currentSum;
            n1 = matrix[row, col];
            n2 = matrix[row, col + 1];
            n3 = matrix[row + 1, col];
            n4 = matrix[row + 1, col + 1];
        }
    }
}
Console.WriteLine($"{n1} {n2}");
Console.WriteLine($"{n3} {n4}");
Console.WriteLine(bestSum);


//   [0,0] + [0,1] 
//   [1,0] + [1,1]