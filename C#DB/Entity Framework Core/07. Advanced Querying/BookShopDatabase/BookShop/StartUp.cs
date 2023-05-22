
using BookShop.Models.Enums;
using System.Text;

namespace BookShop
{
    using BookShop.Models;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            DbInitializer.ResetDatabase(db);

            //var input = Console.ReadLine(); 
            //Console.WriteLine(GetBooksByAgeRestriction(db,input));

            //Console.WriteLine(GetGoldenBooks(db));

            //Console.WriteLine(GetBooksByPrice(db));

            //var year = int.Parse(Console.ReadLine());
            //Console.WriteLine(GetBooksNotReleasedIn(db, year));

            //var genres = Console.ReadLine();
            //Console.WriteLine(GetBooksByCategory(db, genres));

            //var date = DateTime.Parse(Console.ReadLine()); 
            //var dateToString = date.ToString("dd-MM-yyyy");
            //Console.WriteLine(GetBooksReleasedBefore(db,dateToString));

            //var endingString = Console.ReadLine();
            //Console.WriteLine(GetAuthorNamesEndingIn(db, endingString));

            //var containingString = Console.ReadLine()!;
            //Console.WriteLine(GetBookTitlesContaining(db,containingString));

            //var author = Console.ReadLine();
            //Console.WriteLine(GetBooksByAuthor(db,author));

            //var length = int.Parse(Console.ReadLine());
            //Console.WriteLine(CountBooks(db, length));

            //Console.WriteLine(CountCopiesByAuthor(db));

            //Console.WriteLine(GetTotalProfitByCategory(db)); 

            //Console.WriteLine(GetMostRecentBooks(db));

            //IncreasePrices(db);

            RemoveBooks(db);

        }
        //Problem 2
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var result = context.Books
                .AsEnumerable()
                .Where(b => b.AgeRestriction.ToString().ToLower() == command.ToLower())
                .ToList();
            StringBuilder st = new StringBuilder();
            foreach (var book in result.OrderBy(b => b.Title))
            {
                st.AppendLine($"{book.Title}");
            }

            return st.ToString().TrimEnd();
        }
        //Problem 3
        public static string GetGoldenBooks(BookShopContext context)
        {
            var result = context.Books
                .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b=>b.Title)
                .ToList();
            return string.Join(Environment.NewLine, result);
        }
        //Problem 4
        public static string GetBooksByPrice(BookShopContext context)
        {
            StringBuilder st = new StringBuilder();
            var result = context.Books
                .Where(b => b.Price > 40)
                .Select(b => new
                {
                    b.Title,
                    b.Price,
                })
                .OrderByDescending(b => b.Price);
            foreach (var book in result)
            {
                st.AppendLine($"{book.Title} - ${book.Price:F2}");
            }

            return st.ToString().TrimEnd();
        }
        //Problem 5
        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var st = new StringBuilder();
            var result = context.Books
                .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .ToList();
            foreach (var book in result)
            {
                st.AppendLine(book.Title);
            }
            return st.ToString().TrimEnd();
        }
        //Problem 6
        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            var result = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x=>x.ToLower()).ToArray();
            
                var output = context.Books
                    .Where(b => b.BookCategories
                             .Any(bc=>result.Contains(bc.Category.Name.ToLower())))
                    .OrderBy(b => b.Title)
                    .Select(b => b.Title)
                    .ToList();
            
            return string.Join(Environment.NewLine, output);
        }
        //Problem 7
        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            var dateTime = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var result = context.Books
                .Where(b => b.ReleaseDate < dateTime)
                .OrderByDescending(b => b.ReleaseDate)
                .Select(b => new
                {
                    b.Title,
                    b.EditionType,
                    b.Price
                });
            StringBuilder st = new StringBuilder();
            foreach (var book in result)
            {
                st.AppendLine($"{book.Title} - {book.EditionType} - ${book.Price:f2}");
            }
            return st.ToString().TrimEnd();
        }
        //Problem 8
        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var result = context.Authors
                .Where(a => a.FirstName != null && a.FirstName.EndsWith(input))
                .Select(a => $"{a.FirstName} {a.LastName}");
            StringBuilder st = new StringBuilder();
            foreach (var author in result.OrderBy(a => a))
            {
                st.AppendLine($"{author}");
            }
            return st.ToString().TrimEnd();
        }
        //Problem 9
        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            StringBuilder st = new StringBuilder();
            var result = context.Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .OrderBy(b => b.Title)
                .Select(b => b.Title);
            foreach (var book in result)
            {
                st.AppendLine($"{book}");
            }
            return st.ToString().TrimEnd();
        }
        //Problem 10
        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            var result = context.Books
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .OrderBy(b => b.BookId)
                .Select(b => $"{b.Title} ({b.Author.FirstName} {b.Author.LastName})");
            StringBuilder st = new StringBuilder();
            foreach (var book in result)
            {
                st.AppendLine($"{book}");
            }
            return st.ToString().TrimEnd();
        }
        //Problem 11
        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var result = context.Books
                .Where(b => b.Title.Length > lengthCheck)
                .Count();
            return result;
        }
        //Problem 12
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            var result = context.Authors
                .Select(a => new
                {
                    AuthorName = $"{a.FirstName} {a.LastName}",
                    TotalCopiesSold = a.Books.Sum(a => a.Copies)
                })
                .OrderByDescending(a=>a.TotalCopiesSold);
            StringBuilder st = new StringBuilder();
            foreach (var book in result)
            {
                st.AppendLine($"{book.AuthorName} - {book.TotalCopiesSold}");
            }
            return st.ToString().TrimEnd();
        }
        //Problem 13
        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            var result = context.Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    TotalProfit = c.CategoryBooks
                            .Sum(cb => cb.Book.Copies * cb.Book.Price)
                })
                .OrderByDescending(cb => cb.TotalProfit)
                .ThenBy(cb => cb.CategoryName);

            StringBuilder st = new StringBuilder();
            foreach (var book in result)
            {
                st.AppendLine($"{book.CategoryName} ${book.TotalProfit:f2}");
            }
            return st.ToString().TrimEnd();
        }
        //Problem 14
        public static string GetMostRecentBooks(BookShopContext context)
        {
            var result = context.Categories
                .OrderBy(c => c.Name)
                .Select(c => new
                {
                    CategoryName = c.Name,
                    MostRecentBooks = c.CategoryBooks
                    .OrderByDescending(cb => cb.Book.ReleaseDate)
                    .Take(3)
                    .Select(cb => new
                    {
                        BookName = cb.Book.Title,
                        ReleaseYear = cb.Book.ReleaseDate.Value.Year
                    })
                    .ToArray()
                })
                .ToArray();
            StringBuilder st = new StringBuilder();
            foreach (var book in result)
            {
                st.AppendLine($"--{book.CategoryName}");
                foreach (var item in book.MostRecentBooks)
                {
                    st.AppendLine($"{item.BookName} ({item.ReleaseYear})");
                }
            }
            return st.ToString().TrimEnd();


        }
        //Problem 15
        public static void IncreasePrices(BookShopContext context)
        {
           var booksBefore2010 = context.Books
                .Where(b=>b.ReleaseDate.Value.Year < 2010)
                .ToList();
            foreach (var item in booksBefore2010)
            {
                item.Price += 5;
            }
            context.SaveChanges();
        }
        //Problem 16
        public static int RemoveBooks(BookShopContext context)
        {
            var booksToRemove = context.Books
                .Where(b => b.Copies < 4200)
                .ToList();
            context.RemoveRange(booksToRemove);
            context.SaveChanges();
            return booksToRemove.Count;
        }

    }
}


