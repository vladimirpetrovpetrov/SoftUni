public class Program
{
    static void Main()
    {
        var list = Console.ReadLine().Split(", ").ToList();
        var article = new Articles(list[0], list[1], list[2]);
        int times = int.Parse(Console.ReadLine());
        for (int i = 0; i < times; i++)
        {
            var input = Console.ReadLine().Split(": ").ToList();
            string command = input[0];
            string newContent = input[1];
            if (command == "Edit")
            {
                article.Edit(newContent);
            }
            else if(command == "ChangeAuthor")
            {
                article.ChangeAuthor(newContent);
            }
            else if (command == "Rename")
            {
                article.Rename(newContent);
            }
        }
        article.Print();
    }
}
public class Articles
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public Articles(string Title,string Content,string Author) 
    { 
        this.Author = Author;
        this.Title= Title;
        this.Content = Content;
    }

    public void Edit(string newContent)
    {
        this.Content = newContent;
    }
    public void ChangeAuthor(string newAuthor)
    {
        this.Author = newAuthor;
    }
    public void Rename(string newTitle)
    {
        this.Title = newTitle;
    }
    public void Print()
    {
        Console.WriteLine($"{this.Title} - {this.Content}: {this.Author}"); // pogledni tuka tostring
    }

}