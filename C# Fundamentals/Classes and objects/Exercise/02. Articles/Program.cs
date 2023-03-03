namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Article article = new Article(input[0], input[1], input[^1]);
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                var command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Edit")
                {
                    article.Edit(command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                }
                else if (command[0] == "Rename")
                {
                    article.Rename(command[1]);
                }
            }
            Console.WriteLine(article);

        }
    }
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

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
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}