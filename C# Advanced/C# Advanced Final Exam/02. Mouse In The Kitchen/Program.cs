namespace _02._Mouse_In_The_Kitchen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(",",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] coupboard = new char[dimensions[0], dimensions[1]];
            var rowPosition = 0;
            var colPosition = 0;    
            for (int row = 0; row < coupboard.GetLength(0); row++)
            {
                var theRow = Console.ReadLine()!;
                for (int col = 0; col < coupboard.GetLength(1); col++)
                {
                    coupboard[row, col] = theRow[col];
                    if (coupboard[row,col] == 'M')
                    {
                        rowPosition = row;
                        colPosition = col;
                    }
                }
            }
            while (true)
            {
                var command = Console.ReadLine();
                if(command == "danger")
                {
                    break;
                }
                //proverka dali ne izliza ot granicite
                var isOutside = OutsideBorders(coupboard, command, rowPosition, colPosition);
                if(isOutside)
                {
                    Console.WriteLine("No more cheese for tonight!") ;
                    PrintMatrix(coupboard);
                    return;
                }
                //-----------------------------
                //Checking for a wall
                var isWall = CheckForWall(coupboard, command, rowPosition, colPosition);
                if (isWall)
                {
                    continue;
                }
                //------------------------------
                //checking for trap
                var isTrap = CheckForTrap(coupboard, command, rowPosition, colPosition);

                if (command == "up")
                {
                    if (isTrap)
                    {
                        coupboard[rowPosition, colPosition] = '*';
                        coupboard[rowPosition - 1, colPosition] = 'M';
                        Console.WriteLine("Mouse is trapped!");
                        PrintMatrix(coupboard);
                        return;
                    }

                    coupboard[rowPosition, colPosition] = '*';
                    rowPosition -= 1;
                    coupboard[rowPosition, colPosition] = 'M';
                }
                else if (command == "down")
                {
                    if (isTrap)
                    {
                        coupboard[rowPosition, colPosition] = '*';
                        coupboard[rowPosition + 1, colPosition] = 'M';
                        Console.WriteLine("Mouse is trapped!");
                        PrintMatrix(coupboard);
                        return;
                    }
                    coupboard[rowPosition, colPosition] = '*';
                    rowPosition++;
                    coupboard[rowPosition, colPosition] = 'M';

                }
                else if (command == "right")
                {
                    if (isTrap)
                    {
                        coupboard[rowPosition, colPosition] = '*';
                        coupboard[rowPosition, colPosition+1] = 'M';
                        Console.WriteLine("Mouse is trapped!");
                        PrintMatrix(coupboard);
                        return;
                    }
                    coupboard[rowPosition, colPosition] = '*';
                    colPosition++;
                    coupboard[rowPosition, colPosition] = 'M';
                }
                else if (command == "left")
                {
                    if (isTrap)
                    {
                        coupboard[rowPosition, colPosition] = '*';
                        coupboard[rowPosition, colPosition - 1] = 'M';
                        Console.WriteLine("Mouse is trapped!");
                        PrintMatrix(coupboard);
                        return;
                    }
                    coupboard[rowPosition, colPosition] = '*';
                    colPosition--;
                    coupboard[rowPosition, colPosition] = 'M';
                }
                var isThereMoreCheese = MoreCheese(coupboard);
                //checking if there is more cheese in the matrix
                if (!isThereMoreCheese)
                {
                    Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                    PrintMatrix(coupboard);
                    return;
                }
            }
            Console.WriteLine("Mouse will come back later!");
            PrintMatrix(coupboard);
        }
        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }

        static bool OutsideBorders(char[,] matrix, string direction,int rowPosition, int colPosition)
        {
            if(direction == "down")
            {
                var newPosition = rowPosition + 1;
                if(newPosition >= matrix.GetLength(0))
                {
                    return true;
                }
                return false;
            }else if (direction== "up")
            {
                var newPosition = rowPosition - 1;
                if (newPosition < 0)
                {
                    return true;
                }
                return false;
            }
            else if (direction == "left")
            {
                var newPosition = colPosition - 1;
                if (newPosition < 0)
                {
                    return true;
                }
                return false;
            }
            else if (direction == "right")
            {
                var newPosition = colPosition + 1;
                if (newPosition >= matrix.GetLength(1))
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        static bool MoreCheese(char[,] matrix)
        {
            foreach (var item in matrix)
            {
                if(item == 'C')
                {
                    return true;
                }
            }
            return false;
        }
        static bool CheckForWall(char[,] matrix, string direction,int rowPosition,int colPosition)
        {
            if (direction == "down")
            {
                if (matrix[rowPosition+1,colPosition] == '@')
                {
                    return true;
                }
                return false;
            }
            else if (direction == "up")
            {
                if (matrix[rowPosition - 1, colPosition] == '@')
                {
                    return true;
                }
                return false;
            }
            else if (direction == "left")
            {
                if (matrix[rowPosition, colPosition - 1] == '@')
                {
                    return true;
                }
                return false;
            }
            else if (direction == "right")
            {
                if (matrix[rowPosition, colPosition + 1] == '@')
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        static bool CheckForTrap(char[,] matrix, string direction, int rowPosition, int colPosition)
        {
            if (direction == "down")
            {
                if (matrix[rowPosition + 1, colPosition] == 'T')
                {
                    return true;
                }
                return false;
            }
            else if (direction == "up")
            {
                if (matrix[rowPosition - 1, colPosition] == 'T')
                {
                    return true;
                }
                return false;
            }
            else if (direction == "left")
            {
                if (matrix[rowPosition, colPosition - 1] == 'T')
                {
                    return true;
                }
                return false;
            }
            else if (direction == "right")
            {
                if (matrix[rowPosition, colPosition + 1] == 'T')
                {
                    return true;
                }
                return false;
            }
            return false;
        }





    }
}