using System;

namespace Submatrix_3x3_with_max_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                {2,  3,  4,  11, 2,},
                {22, 3,  1,  0,  11},
                {3,  99,  0,  31, 8 },
                {1,  2,  3,  22, 1 }
            };
            int maxSum = 0;
            int sum = 0;
            int startingRow = 0;
            int startingCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    sum += matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                           matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                           matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > maxSum)
                    {
                        startingRow = row;
                        startingCol = col;
                        maxSum = sum;
                    }
                    sum = 0;
                }

            }

            for (int row = startingRow; row < startingRow + 3; row++)
            {
                for (int col = startingCol; col < startingCol + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Sum: " + maxSum);
        }
    }
}
