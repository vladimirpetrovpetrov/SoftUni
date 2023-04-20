using System.Runtime.CompilerServices;

char[,] ticTacToe = new char[,]
{
    {'_','_','_' },
    {'_','_','_' },
    {'_','_','_' }
};



PrintMatrix(ticTacToe);
Console.WriteLine();
int player = 1;
while (true)
{

    Console.WriteLine($"Player {(player == -1 ? 'O' : 'X')} is on move: ");

    Console.Write($"Row: ");
    int row = int.Parse(Console.ReadLine());

    Console.Write($"Col: ");
    int col = int.Parse(Console.ReadLine());

    if (row > 2 || row < 0 || col > 2 || col < 0 || ticTacToe[row, col] != '_')
    {
        Console.WriteLine("Invalid coordinates!");
        continue;
    }

    char symbol = 'X';
    if (player == -1)
    {
        symbol = 'O';
    }
    ticTacToe[row, col] = symbol;
    Console.Clear();
    PrintMatrix(ticTacToe);

    if (CheckHorizontal(ticTacToe, symbol) ||
        CheckVertically(ticTacToe, symbol) ||
        CheckDiagonalLeft(ticTacToe, symbol) ||
        CheckDiagonalRight(ticTacToe, symbol)
        )
    {
        Console.WriteLine($"Player {symbol} won the game!");
        break;
    }

    player *= -1;

    if (IsGameEnd(ticTacToe))
    {
        Console.WriteLine("No winner!");
    }
}

static bool IsGameEnd(char[,] ticTacToe)
{
    foreach (var item in ticTacToe)
    {
        if (item == '_')
        {
            return false;
        }
    }
    return true;
}

static bool CheckHorizontal(char[,] ticTacToe, char symbol)
{

    for (int row = 0; row < ticTacToe.GetLength(0); row++)
    {
        bool isWinner = true;
        for (int col = 0; col < ticTacToe.GetLength(1); col++)
        {
            if (ticTacToe[row, col] != symbol)
            {
                isWinner = false;
                break;
            }
        }
        if (isWinner)
        {
            return true;
        }
    }
    return false;
}
static bool CheckVertically(char[,] ticTacToe, char symbol)
{
    for (int col = 0; col < ticTacToe.GetLength(1); col++)
    {
        bool isWinner = true;
        for (int row = 0; row < ticTacToe.GetLength(0); row++)
        {
            if (ticTacToe[row, row] != symbol)
            {
                isWinner = false;
                break;
            }
        }
        if (isWinner)
        {
            return true;
        }
    }
    return false;
}
static bool CheckDiagonalLeft(char[,] ticTacToe, char symbol)
{
    bool isWinner = true;
    for (int row = 0; row < ticTacToe.GetLength(0); row++)
    {

        if (ticTacToe[row, row] != symbol)
        {
            isWinner = false;
            break;
        }

    }
    if (isWinner)
    {
        return true;
    }
    return false;
}
static bool CheckDiagonalRight(char[,] ticTacToe, char symbol)
{
    bool isWinner = true;
    for (int col = 0; col < ticTacToe.GetLength(1); col++)
    {

        if (ticTacToe[ticTacToe.GetLength(0) - 1 - col, col] != symbol)
        {
            isWinner = false;
        }

    }
    if (isWinner)
    {
        return true;
    }
    return false;
}

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