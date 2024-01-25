using System;
namespace Мost_repeated_elements_in_string_matrix
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            //most repeated string (row,col or diagonal)
            string[,] m =
            {
                {"ha","fifi","ho","hi" },
                {"fo","ha","hi","xx" },
                {"xxx","ho","ha","xx" }
            };
            string[,] m2 =
            {
                {"s" , "qq", "s"},
                {"pp", "pp", "s"},
                {"pp", "qq", "s"}
            };

            var count = 1;
            var bestCount = 1;
            var bestString = "";


            for (int r = 0; r < m2.GetLength(0); r++)
            {
                for (int c = 0; c < m2.GetLength(1); c++)
                {
                    count = SearchCount(m2, r, c);
                    if (count > bestCount)
                    {
                        bestString = m2[r, c];
                        bestCount = count;
                    }
                }
                count = 1;
            }
            Console.WriteLine($"Most sequentially repeated string(row,col or diagonal) : \"{bestString}\" - {bestCount} times.");
        }
        static int SearchCount(string[,] m, int r, int c)
        {
            int count = 1;
            if (c == m.GetLength(1) - 1 && r == m.GetLength(0) - 1)
            {
                return 1;
            } //4,4
            else if (c == m.GetLength(1) - 1) //last column
            {
                while (m[r, c] == m[r + 1, c])
                {
                    count++;
                    if (m[r, c] == m[r + 1, c])
                    {
                        r += 1;
                    }
                    else
                    {
                        return count;
                        
                    }

                    if (r == m.GetLength(0) - 1)
                    {
                        return count;
                    }
                }
            }
            else if (r >= m.GetLength(0) - 1) //last row
            {
                while (m[r, c] == m[r, c + 1])
                {
                    count++;
                    if (m[r, c] == m[r, c + 1])
                    {
                        c += 1;
                    }
                    else
                    {
                        return count;
                        break;
                    }

                    if (c >= m.GetLength(1) - 1)
                    {
                        return count;
                    }
                }
            }
            else
            {
                while (m[r, c] == m[r + 1, c + 1] || m[r, c] == m[r, c + 1] || m[r, c] == m[r + 1, c])
                {
                    
                    count++;
                    if (m[r, c] == m[r + 1, c + 1])
                    {

                        r += 1;
                        c += 1;
                    }
                    else if (m[r, c] == m[r, c + 1])
                    {
                        c += 1;
                    }
                    else if (m[r, c] == m[r + 1, c])
                    {
                        r += 1;
                    }
                    else { break; }

                    if (r >= m.GetLength(0) - 1 || c >= m.GetLength(1) - 1)
                    {
                        return count;
                    }
                }
            }
            return count;
        }


    }
}
