var sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
var rows = sizes[0];
var cols = sizes[1];

var matrix = new char[rows, cols];

var startingRow = 0;
var startingColumn = 0;

//Initializing the matrix
for (int row = 0; row < rows; row++)
{
    var input = Console.ReadLine().ToCharArray();
    for (int col = 0; col < cols; col++)
    {
        if (input[col] == 'P')
        {
            startingRow = row;
            startingColumn = col;
        }
        matrix[row, col] = input[col];
    }
}

//Finding indexes of the initial bunnies
List<string> currentBunnies = new List<string>();
List<string> allBunnies = new List<string>(currentBunnies);
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row, col] == 'B')
        {
            currentBunnies.Add($"{row}-{col}");
        }
    }
}
allBunnies.AddRange(currentBunnies);
var directions = Console.ReadLine().ToCharArray();
bool hasWon = false;
bool hasDied = false;
var counter = 0;
//Main loop(Player and Bunny moving)
while(!hasWon && !hasDied)
{
    //Player moving
    if (directions[counter] == 'L')
    {
        if (startingColumn == 0)
        {
            hasWon = true;
            matrix[startingRow, startingColumn] = '.';
            break;
        }else if (matrix[startingRow,startingColumn-1] == 'B')
        {
            hasDied = true;
            matrix[startingRow, startingColumn] = '.';
            startingColumn--;
            break;
        }
        matrix[startingRow, startingColumn] = '.';
        startingColumn--;
        matrix[startingRow, startingColumn] = 'P';
        //един път ако ние настъпим заек и един пък ще направя после ако заек ме засъпи мен
    }
    else if (directions[counter] == 'R')
    {
        if (startingColumn == matrix.GetLength(1)-1)
        {
            hasWon = true;
            matrix[startingRow, startingColumn] = '.';
            break;
        }
        else if (matrix[startingRow, startingColumn + 1] == 'B')
        {
            hasDied = true;
            matrix[startingRow, startingColumn] = '.';
            startingColumn++;
            break;
        }
        matrix[startingRow, startingColumn] = '.';
        startingColumn++;
        matrix[startingRow, startingColumn] = 'P';
    }
    else if (directions[counter] == 'U')
    {
        if (startingRow == 0)
        {
            hasWon = true;
            matrix[startingRow, startingColumn] = '.';
            break;
        }
        else if (matrix[startingRow-1, startingColumn] == 'B')
        {
            hasDied = true;
            matrix[startingRow, startingColumn] = '.';
            startingRow--;
            break;
        }
        matrix[startingRow, startingColumn] = '.';
        startingRow--;
        matrix[startingRow, startingColumn] = 'P';
    }
    else if (directions[counter] == 'D')
    {
        if (startingRow == matrix.GetLength(0) - 1)
        {
            hasWon = true;
            matrix[startingRow, startingColumn] = '.';
            break;
        }
        else if (matrix[startingRow + 1, startingColumn] == 'B')
        {
            hasDied = true;
            matrix[startingRow, startingColumn] = '.';
            startingRow++;
            break;
        }
        matrix[startingRow, startingColumn] = '.';
        startingRow++;
        matrix[startingRow, startingColumn] = 'P';
    }
    counter++;
    //--------------------------------------------------------
    //Bunny moving
    for (int j = 0; j < currentBunnies.Count; j++)
    {
        var curBunnyRow = int.Parse(currentBunnies[j].Split("-", StringSplitOptions.RemoveEmptyEntries)[0]);
        var curBunnyCol = int.Parse(currentBunnies[j].Split("-", StringSplitOptions.RemoveEmptyEntries)[1]);
        //LEFT
        if (curBunnyCol > 0 && matrix[curBunnyRow, curBunnyCol - 1] != 'B')
        {
            if (matrix[curBunnyRow,curBunnyCol-1] == 'P')
            {
                hasDied = true;
            }
            matrix[curBunnyRow, curBunnyCol - 1] = 'B';
            allBunnies.Add($"{curBunnyRow}-{curBunnyCol - 1}");
        }
        //RIGHT
        if (curBunnyCol < matrix.GetLength(1) - 1 && matrix[curBunnyRow, curBunnyCol + 1] != 'B')
        {
            if (matrix[curBunnyRow, curBunnyCol + 1] == 'P')
            {
                hasDied = true;
            }
            matrix[curBunnyRow, curBunnyCol + 1] = 'B';
            allBunnies.Add($"{curBunnyRow}-{curBunnyCol + 1}");
        }
        //UP
        if (curBunnyRow > 0 && matrix[curBunnyRow - 1, curBunnyCol] != 'B')
        {
            if (matrix[curBunnyRow-1, curBunnyCol] == 'P')
            {
                hasDied = true;
            }
            matrix[curBunnyRow - 1, curBunnyCol] = 'B';
            allBunnies.Add($"{curBunnyRow - 1}-{curBunnyCol}");
        }
        //DOWN
        if (curBunnyRow < matrix.GetLength(0) - 1 && matrix[curBunnyRow + 1, curBunnyCol] != 'B')
        {
            if (matrix[curBunnyRow + 1, curBunnyCol] == 'P')
            {
                hasDied = true;
            }
            matrix[curBunnyRow + 1, curBunnyCol] = 'B';
            allBunnies.Add($"{curBunnyRow + 1}-{curBunnyCol}");
        }
    }
    currentBunnies.AddRange(allBunnies);
    currentBunnies.Sort();
    currentBunnies = currentBunnies.Distinct().ToList();
}
    
    if (hasWon)
    {
    for (int j = 0; j < currentBunnies.Count; j++)
    {
        var curBunnyRow = int.Parse(currentBunnies[j].Split("-", StringSplitOptions.RemoveEmptyEntries)[0]);
        var curBunnyCol = int.Parse(currentBunnies[j].Split("-", StringSplitOptions.RemoveEmptyEntries)[1]);
        //LEFT
        if (curBunnyCol > 0 && matrix[curBunnyRow, curBunnyCol - 1] != 'B')
        {
            if (matrix[curBunnyRow, curBunnyCol - 1] == 'P')
            {
                hasDied = true;
            }
            matrix[curBunnyRow, curBunnyCol - 1] = 'B';
            allBunnies.Add($"{curBunnyRow}-{curBunnyCol - 1}");
        }
        //RIGHT
        if (curBunnyCol < matrix.GetLength(1) - 1 && matrix[curBunnyRow, curBunnyCol + 1] != 'B')
        {
            if (matrix[curBunnyRow, curBunnyCol + 1] == 'P')
            {
                hasDied = true;
            }
            matrix[curBunnyRow, curBunnyCol + 1] = 'B';
            allBunnies.Add($"{curBunnyRow}-{curBunnyCol + 1}");
        }
        //UP
        if (curBunnyRow > 0 && matrix[curBunnyRow - 1, curBunnyCol] != 'B')
        {
            if (matrix[curBunnyRow - 1, curBunnyCol] == 'P')
            {
                hasDied = true;
            }
            matrix[curBunnyRow - 1, curBunnyCol] = 'B';
            allBunnies.Add($"{curBunnyRow - 1}-{curBunnyCol}");
        }
        //DOWN
        if (curBunnyRow < matrix.GetLength(0) - 1 && matrix[curBunnyRow + 1, curBunnyCol] != 'B')
        {
            if (matrix[curBunnyRow + 1, curBunnyCol] == 'P')
            {
                hasDied = true;
            }
            matrix[curBunnyRow + 1, curBunnyCol] = 'B';
            allBunnies.Add($"{curBunnyRow + 1}-{curBunnyCol}");
        }
    }
    PrintMatrix(matrix);
    Console.WriteLine($"won: {startingRow} {startingColumn}");
        return;
    }
    if (hasDied)
    {
    for (int j = 0; j < currentBunnies.Count; j++)
    {
        var curBunnyRow = int.Parse(currentBunnies[j].Split("-", StringSplitOptions.RemoveEmptyEntries)[0]);
        var curBunnyCol = int.Parse(currentBunnies[j].Split("-", StringSplitOptions.RemoveEmptyEntries)[1]);
        //LEFT
        if (curBunnyCol > 0 && matrix[curBunnyRow, curBunnyCol - 1] != 'B')
        {
            if (matrix[curBunnyRow, curBunnyCol - 1] == 'P')
            {
                hasDied = true;
            }
            matrix[curBunnyRow, curBunnyCol - 1] = 'B';
            allBunnies.Add($"{curBunnyRow}-{curBunnyCol - 1}");
        }
        //RIGHT
        if (curBunnyCol < matrix.GetLength(1) - 1 && matrix[curBunnyRow, curBunnyCol + 1] != 'B')
        {
            if (matrix[curBunnyRow, curBunnyCol + 1] == 'P')
            {
                hasDied = true;
            }
            matrix[curBunnyRow, curBunnyCol + 1] = 'B';
            allBunnies.Add($"{curBunnyRow}-{curBunnyCol + 1}");
        }
        //UP
        if (curBunnyRow > 0 && matrix[curBunnyRow - 1, curBunnyCol] != 'B')
        {
            if (matrix[curBunnyRow - 1, curBunnyCol] == 'P')
            {
                hasDied = true;
            }
            matrix[curBunnyRow - 1, curBunnyCol] = 'B';
            allBunnies.Add($"{curBunnyRow - 1}-{curBunnyCol}");
        }
        //DOWN
        if (curBunnyRow < matrix.GetLength(0) - 1 && matrix[curBunnyRow + 1, curBunnyCol] != 'B')
        {
            if (matrix[curBunnyRow + 1, curBunnyCol] == 'P')
            {
                hasDied = true;
            }
            matrix[curBunnyRow + 1, curBunnyCol] = 'B';
            allBunnies.Add($"{curBunnyRow + 1}-{curBunnyCol}");
        }
    }
    PrintMatrix(matrix);
        Console.WriteLine($"dead: {startingRow} {startingColumn}");
        return;
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