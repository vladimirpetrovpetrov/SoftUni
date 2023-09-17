using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Iterator;

public class Book
{
    private List<string> authors;

    public Book(string title, int year, params string[] authors)
    {
        this.Title = title;
        this.Year = year;
        this.authors = new List<string>(authors);
    }

    public string Title { get; private set; }

    public int Year { get; private set; }

    public IReadOnlyCollection<string> Authors
    {
        get
        {
            return this.authors.AsReadOnly();
        }
    }
}
