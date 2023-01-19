using System;

namespace Diamond_with_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //var n = 8;
            if (n == 2 || n == 1)
            {
                Console.Write(new string('*', n));
                return;
            }
            else if (n % 2 != 0)
            {

                Console.Write(new string('-', ((n - 1) / 2)));
                Console.Write("*");
                Console.Write(new string('-', ((n - 1) / 2)));

            }
            else
            {
                Console.Write(new string('-', ((n - 1) / 2)));
                Console.Write(new string('*', 2));
                Console.Write(new string('-', ((n - 1) / 2)));

            }
            Console.WriteLine();

            //ако е четно

            //тяло горна част 
            if (n % 2 != 0)
            {
                var space = (n - 2) / 2; //4

                var space2 = 1;
                for (int row = 0; row < (n - 1) / 2; row++)
                {
                    for (int spaces1 = 0; spaces1 < space; spaces1++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("*");


                    for (int spaces2 = 0; spaces2 < space2; spaces2++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("*");

                    for (int spaces1 = 0; spaces1 < space; spaces1++)
                    {
                        Console.Write("-");
                    }
                    space--;
                    space2++;
                    space2++;

                    Console.WriteLine();
                }
                //тяло долна част
                space = 1;
                space2 = space2 - 4;
                for (int row = 0; row < (n - 2) / 2; row++)
                {
                    for (int spaces1 = 0; spaces1 < space; spaces1++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("*");


                    for (int spaces2 = 0; spaces2 < space2; spaces2++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("*");

                    for (int spaces1 = 0; spaces1 < space; spaces1++)
                    {
                        Console.Write("-");
                    }
                    space++;
                    space2--;
                    space2--;

                    Console.WriteLine();
                }
            }

            //ако е нечетно
            else
            {
                var space2 = 2;
                var space = (n - 4) / 2; //4


                for (int row = 0; row < (n - 2) / 2; row++)
                {
                    for (int spaces1 = 0; spaces1 < space; spaces1++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("*");


                    for (int spaces2 = 0; spaces2 < space2; spaces2++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("*");

                    for (int spaces1 = 0; spaces1 < space; spaces1++)
                    {
                        Console.Write("-");
                    }
                    space--;
                    space2++;
                    space2++;

                    Console.WriteLine();
                }

                //тяло долна част
                space = 1;
                space2 = space2 - 4;
                for (int row = 0; row < ((n - 2) / 2) - 1; row++)
                {
                    for (int spaces1 = 0; spaces1 < space; spaces1++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("*");


                    for (int spaces2 = 0; spaces2 < space2; spaces2++)
                    {
                        Console.Write("-");
                    }
                    Console.Write("*");

                    for (int spaces1 = 0; spaces1 < space; spaces1++)
                    {
                        Console.Write("-");
                    }
                    space++;
                    space2--;
                    space2--;

                    Console.WriteLine();
                }
            }

            //тяло край
            if (n % 2 != 0)
            {

                Console.Write(new string('-', ((n - 1) / 2)));
                Console.Write("*");
                Console.Write(new string('-', ((n - 1) / 2)));

            }
            else
            {
                Console.Write(new string('-', ((n - 1) / 2)));
                Console.Write(new string('*', 2));
                Console.Write(new string('-', ((n - 1) / 2)));

            }

        }
    }
}