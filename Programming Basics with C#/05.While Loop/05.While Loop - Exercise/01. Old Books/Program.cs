using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {



            var neededBook = Console.ReadLine();
            var searchedBook = " ";
            var count = -1;
            while(searchedBook != neededBook && searchedBook != "No More Books")
            {
                searchedBook = Console.ReadLine();
                count++;

            }
            if (searchedBook == neededBook)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }










        }
    }
}
