var n = int.Parse(Console.ReadLine());
char[,] matrix = new char[n, n];
var directions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
//Initializing
var startingRow = 0;
var startingCol = 0;
for (int row = 0; row < n; row++)
{
    var rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int col = 0; col < n; col++)
    {
        if(rowData[col] == 's') //find the starting position
        {
            startingRow = row;
            startingCol = col;
        }
        matrix[row, col] = rowData[col];
    }
}
//Miner starting positions is on "s"

//count the coals first
var coalsCount = 0;
foreach (var item in matrix)
{
    if(item == 'c')
    {
        coalsCount++;
    }
}

//start moving - we move until we collect all coals or we are out of more steps or we step on 'e'
for (int i = 0; i < directions.Count; i++)
{

    if (directions[i] == "left")
    {
        if(startingCol > 0)
        {
            startingCol -= 1;
        }
    }else if (directions[i] == "right")
    {
        if (startingCol < matrix.GetLength(0) - 1)
        {
            startingCol += 1;
        }
    }
    else if (directions[i] == "up")
    {
        if(startingRow > 0)
        {
            startingRow -= 1;
        }
    }
    else if (directions[i] == "down")
    {
        if (startingRow < matrix.GetLength(0) - 1)
        {
            startingRow += 1;
        }
    }

    if (matrix[startingRow,startingCol] == 'e')
    {
        Console.WriteLine($"Game over! ({startingRow}, {startingCol})");
        return;
    }
    if (matrix[startingRow, startingCol] == 'c')
    {
        matrix[startingRow, startingCol] = '*';
        coalsCount--;
        if(coalsCount == 0)
        {
            Console.WriteLine($"You collected all coals! ({startingRow}, {startingCol})");
            return;
        }
    }
}
Console.WriteLine($"{coalsCount} coals left. ({startingRow}, {startingCol})");
static void PrintMatrix(char[,] matrix)
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