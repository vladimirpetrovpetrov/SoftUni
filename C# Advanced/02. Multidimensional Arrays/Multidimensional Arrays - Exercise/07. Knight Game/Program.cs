var n = int.Parse(Console.ReadLine());
var chess = new char[n,n];
for (int row = 0; row < n; row++)
{
	var input = Console.ReadLine().ToCharArray();
	for (int col = 0; col < n; col++)
	{
		chess[row,col] = input[col];
	}
}
var minimumRemoves = 0;

while (true)
{
    var biggestCount = 0;
    var knightRow = 0;
    var knightCol = 0;
    for (int row = 0; row < n; row++)
    {
        for (int col = 0; col < n; col++)
        {
            var count = 0;
            count += CheckLong(chess, row, col);
            count += CheckShort(chess, row, col);

            if (count > biggestCount)
            {
                biggestCount = count;
                knightRow = row;
                knightCol = col;
            }
        }
    }
    if(biggestCount == 0)
    {
        Console.WriteLine(minimumRemoves);
        break;
    }
    chess[knightRow, knightCol] = '0';
    minimumRemoves++;
}
static int CheckShort(char[,] chess, int row, int col)
{
    var count = 0;
    if (chess[row, col] == 'K')
    {
        //SHORT UP LEFT 
        if (row > 0 && col > 1)
        {
            if (chess[row - 1, col - 2] == 'K')
            {
                count++;
            }
        }
        //SHORT UP RIGHT
        if (row > 0 && col < chess.GetLength(1) - 2)
        {
            if (chess[row - 1, col + 2] == 'K')
            {
                count++;
            }
        }
        //SHORT DOWN LEFT
        if (row < chess.GetLength(1) - 1 && col > 1)
        {
            if (chess[row + 1, col - 2] == 'K')
            {
                count++;
            }
        }
        //SHORT DOWN RIGHT
        if (row < chess.GetLength(1) - 1 && col < chess.GetLength(1) - 2)
        {
            if (chess[row + 1, col + 2] == 'K')
            {
                count++;
            }
        }
    }

    return count;
}
static int CheckLong(char[,] chess, int row, int col)
{
    var count = 0;
    if (chess[row, col] == 'K')
    {
        //LONG UP LEFT 
        if (row > 1 && col > 0)
        {
            if (chess[row - 2, col - 1] == 'K')
            {
                count++;
            }
        }
        //LONG UP RIGHT
        if (row > 1 && col < chess.GetLength(1) - 1)
        {
            if (chess[row - 2, col + 1] == 'K')
            {
                count++;
            }
        }
        //LONG DOWN LEFT
        if (row < chess.GetLength(1) - 2 && col > 0)
        {
            if (chess[row + 2, col - 1] == 'K')
            {
                count++;
            }
        }
        //LONG DOWN RIGHT
        if (row < chess.GetLength(1) - 2 && col < chess.GetLength(1) - 1)
        {
            if (chess[row + 2, col + 1] == 'K')
            {
                count++;
            }
        }
    }

    return count;
}