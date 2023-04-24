var sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
var rows = sizes[0];
var cols = sizes[1];
var matrix = new char[rows, cols];
var playerRow = 0;
var playerCol = 0;
List<string> currentBunnies = new List<string>();
List<string> allBunnies = new List<string>();
//Initializing the matrix.
for (int row = 0; row < rows; row++)
{
    var input = Console.ReadLine().ToCharArray();
    for (int col = 0; col < cols; col++)
    {
        if (input[col] == 'P')
        {
            //Initializing starting player coords
            playerRow = row;
            playerCol = col;
        }
        else if (input[col] == 'B')
        {
            currentBunnies.Add($"{row},{col}");
        }
        matrix[row, col] = input[col];

    }
}
allBunnies.AddRange(currentBunnies);
var directions = Console.ReadLine();

foreach (var item in directions)
{
    var oldRow = playerRow;
    var oldCol = playerCol;
    matrix[playerRow, playerCol] = '.';
    //left
    if (item == 'L')
    {
        playerCol--;
    }
    //right
    else if (item == 'R')
    {
        playerCol++;
    }
    //up
    else if (item == 'U')
    {
        playerRow--;
    }
    //down
    else if (item == 'D')
    {
        playerRow++;
    }
    BunnyMove(matrix, currentBunnies, allBunnies);

    allBunnies = allBunnies.Distinct().ToList();
    currentBunnies.AddRange(allBunnies);
    currentBunnies = currentBunnies.Distinct().ToList();
    currentBunnies.Sort();
    if(playerCol<0||playerCol>matrix.GetLength(1)-1||playerRow<0||playerRow> matrix.GetLength(0) - 1)
    {
        PrintMatrix(matrix);
        Console.WriteLine($"won: {oldRow} {oldCol}");
        break;
    }
    if (matrix[playerRow,playerCol] == 'B')
    {
        PrintMatrix(matrix);
        Console.WriteLine($"dead: {playerRow} {playerCol}");
        break;
    }
}
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
static void BunnyMove(char[,] matrix, List<string> currentBunnies, List<string> allBunnies)
{
    foreach (var coord in currentBunnies)
    {
        
        var bRow = int.Parse(coord.Split(",").ToArray()[0]);
        var bCol = int.Parse(coord.Split(",").ToArray()[1]);

        //left
        if (bCol > 0)
        {
            matrix[bRow, bCol - 1] = 'B';
            allBunnies.Add($"{bRow},{bCol - 1}");
        }
        //right
        if (bCol < matrix.GetLength(1) - 1)
        {
            matrix[bRow, bCol + 1] = 'B';
            allBunnies.Add($"{bRow},{bCol+1}");
        }
        //up
        if (bRow > 0)
        {
            matrix[bRow - 1, bCol] = 'B';
            allBunnies.Add($"{bRow - 1},{bCol}");
        }
        //down
        if (bRow < matrix.GetLength(0) - 1)
        {
            matrix[bRow + 1, bCol] = 'B';
            allBunnies.Add($"{bRow + 1},{bCol}");
        }
    }


}