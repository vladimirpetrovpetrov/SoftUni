var n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];
for (int row = 0; row < n; row++)
{
    var rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int col = 0; col < n; col++)
    {
        matrix[row, col] = rowData[col];
    }
}
List<string> bombCoords = new(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList());
//CHECK IF THE BOMB  IS ALREADY EXPLODED
for (int i = 0; i < bombCoords.Count-1; i++)
{
    for (int j = i+1; j < bombCoords.Count; j++)
    {
        if (bombCoords[i] == bombCoords[j])
        {
            bombCoords.RemoveAt(j);
            j--;
        }
    }
}
for (int i = 0; i < bombCoords.Count; i++)
{
    var coords = bombCoords[i].Split(",", StringSplitOptions.RemoveEmptyEntries);
    var bombRow = int.Parse(coords[0]);
    var bombCol = int.Parse(coords[1]);
    if (matrix[bombRow,bombCol] <= 0)
    {
        continue;
    }

    if (bombRow > 0 && matrix[bombRow - 1, bombCol] > 0)
    {
        //upper
        matrix[bombRow - 1, bombCol] -= matrix[bombRow, bombCol];
    }
    if(bombRow > 0 && bombCol < matrix.GetLength(0) - 1 && matrix[bombRow - 1, bombCol + 1] > 0)
    {
        //upper,right
        matrix[bombRow - 1, bombCol+1] -= matrix[bombRow, bombCol];
    }
    if (bombCol < matrix.GetLength(0) - 1 && matrix[bombRow, bombCol + 1] > 0)
    {
        //right
        matrix[bombRow, bombCol + 1] -= matrix[bombRow, bombCol];
    }
    if (bombRow<matrix.GetLength(0)-1 && bombCol < matrix.GetLength(0) - 1 && matrix[bombRow+1, bombCol + 1] > 0)
    {
        //lower,right
        matrix[bombRow+1, bombCol + 1] -= matrix[bombRow, bombCol];
    }
    if (bombRow < matrix.GetLength(0) - 1 && matrix[bombRow + 1, bombCol] > 0)
    {
        //lower
        matrix[bombRow + 1, bombCol] -= matrix[bombRow, bombCol];
    }
    if (bombRow < matrix.GetLength(0) - 1 && bombCol > 0 && matrix[bombRow + 1, bombCol - 1] > 0)
    {
        //lower,left
        matrix[bombRow + 1, bombCol-1] -= matrix[bombRow, bombCol];
    }
    if (bombCol > 0 && matrix[bombRow, bombCol - 1] > 0)
    {
        //left
        matrix[bombRow, bombCol - 1] -= matrix[bombRow, bombCol];
    }
    if (bombCol > 0 && bombRow >0 && matrix[bombRow - 1, bombCol - 1] > 0)
    {
        //upper left
        matrix[bombRow -1, bombCol - 1] -= matrix[bombRow, bombCol];
    }
    matrix[bombRow, bombCol] = 0;
}
var aliveCells = 0;
var sum = 0;
foreach (var item in matrix)
{
    if (item > 0)
    {
        sum += item;
        aliveCells++;
    }
}
Console.WriteLine($"Alive cells: {aliveCells}");
Console.WriteLine($"Sum: {sum}");
PrintMatrix(matrix);


static void PrintMatrix(int[,] matrix)
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