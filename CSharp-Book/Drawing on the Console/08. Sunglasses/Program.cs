using System;

namespace Sunglasses_with_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            //var n = 7;


            //първи ред
            Console.Write(new string('*', (2 * n)));
            Console.Write(new string(' ', (n)));
            Console.Write(new string('*', (2 * n)));
            Console.WriteLine();

            for (int row = 0; row < n - 2; row++)
            {

                for (int col = 0; col < 2 * n; col++)
                {

                    if (col == 0 || col == 2 * n - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("/");
                    }

                }
                //ако n = 5 -> ako n e nechetno (ako n+1 /2)

                for (int space = 0; space < n; space++)
                {
                    if (n % 2 != 0)
                    {
                        if (row == ((n - 2)) / 2)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if (row + 1 == (n - 2) / 2)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }


                for (int col = 0; col < 2 * n; col++)
                {
                    if (col == 0 || col == 2 * n - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("/");
                    }


                }
                Console.WriteLine();

            }

            //последен ред

            Console.Write(new string('*', (2 * n)));
            Console.Write(new string(' ', (n)));
            Console.Write(new string('*', (2 * n)));

        }
    }
}
