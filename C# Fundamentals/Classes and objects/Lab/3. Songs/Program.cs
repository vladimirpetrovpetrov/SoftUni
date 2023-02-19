public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var songs = new List<Song>();
        for (int i = 0; i < n; i++)
        {
            var list = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries).ToList();
            songs.Add(new Song(list[0], list[1], list[2]));
        }
        var type = Console.ReadLine();

        if (type == "all")
        {
            for (int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine(songs[i].Name);
            }
        }
        else
        {
            for (int i = 0; i < songs.Count; i++)
            {
                if (songs[i].TypeList == type)
                {
                    Console.WriteLine(songs[i].Name);
                }
            }
        }



    }
}
public class Song
{
    private string typeList;
    private string name;
    private string time;

    public string TypeList
    {
        get { return this.typeList; }
        set { this.typeList = value; }
    }
    public string Name
    {
        get { return this.name; }
        set { this.typeList = value; }
    }
    public string Time
    {
        get { return this.time; }
        set { this.typeList = value; }
    }
    public Song(string typeList,string name,string time)
    {
        this.typeList = typeList;
        this.name = name;
        this.time = time;
    }
}