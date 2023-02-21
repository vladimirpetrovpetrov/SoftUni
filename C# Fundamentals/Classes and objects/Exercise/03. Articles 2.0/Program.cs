public class Program
{
    static void Main()
    {
        int times = int.Parse(Console.ReadLine());
        List<Articles> articles = new List<Articles>();
        for (int i = 0; i < times; i++)
        {
            var input = Console.ReadLine().Split(", ").ToList();
            articles.Add(new Articles(input[0], input[1], input[2]));
        }
        articles.ForEach(article => article.Print());
    }
    public class Articles
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Articles(string Title, string Content, string Author)
        {
            this.Author = Author;
            this.Title = Title;
            this.Content = Content;
        }
        public void Print()
        {
            Console.WriteLine($"{this.Title} - {this.Content}: {this.Author}");
        }

    }
}