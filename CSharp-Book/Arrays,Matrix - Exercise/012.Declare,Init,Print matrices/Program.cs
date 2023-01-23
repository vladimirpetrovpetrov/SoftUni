using System;
using System.Data.Common;

namespace _012.Declare_Init_Print_matrices
{
    internal class Program
    {
        //A //1 5 9  13 //B //1 8 9  16 
        //2 6 10 14     //2 7 10 15
        //3 7 11 15     //3 6 11 14
        //4 8 12 16     //4 5 12 13

        //C //7 11 14 16 
            //4 8  12 15 
            //2 5  9 13 
            //1 3  6 10 
        static void Main(string[] args)
        {
            Console.WriteLine("Rows: ");
            var rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Cols: ");
            var cols = int.Parse(Console.ReadLine());
            
            int[,] matrix = new int[rows, cols];
            int startingNum = 0;

            //C //TODO
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    matrix[rows-1-row,col] = ++startingNum;
                }
            }


            //B
            /*
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = ++startingNum;
                    }
                }

                if (col % 2 == 1)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        
                        matrix[row, col] = startingNum--;
                        
                    }
                }
                startingNum += rows;
            }
            */



            //A
            /*
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = startingNum1;
                    startingNum1++;
                }
            }
            */
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,-3}",matrix[row,col]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
