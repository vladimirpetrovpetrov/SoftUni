var n = int.Parse(Console.ReadLine());
List<Dragon> dragons = new List<Dragon>();
List<Color> colors = new List<Color>();
for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    var dragonColor = input[0];
    var dragonName = input[1];
    int dragonDamage = 0;
    if (input[2] == "null")
    {
        dragonDamage = 45;
    }
    else
    {
        dragonDamage = int.Parse(input[2]);
    }
    int dragonHealth = 0;
    if (input[3] == "null")
    {
        dragonHealth = 250;
    }
    else
    {
        dragonHealth = int.Parse(input[3]);
    }
    int dragonArmor = 0;
    if (input[4] == "null")
    {
        dragonArmor = 10;
    }
    else
    {
        dragonArmor = int.Parse(input[4]);
    }

    if(!dragons.Any(x=>x.Color == dragonColor && x.Name == dragonName))
    {
        Dragon dragon = new Dragon(dragonColor, dragonName, dragonDamage, dragonHealth, dragonArmor);
        dragons.Add(dragon);
        if (!colors.Any(x => x.Dragons.Any(x => x.Color == dragonColor)))
        {
            colors.Add(new Color(dragon));
        }
        else
        {
            
            var searchedColor = colors.Find(x => x.Name == dragonColor);
            searchedColor.Dragons.Add(dragon);
        }
    }
    else
    {
        var originalDragon = dragons.Find(x => x.Name == dragonName && x.Color == dragonColor);
        originalDragon.UpdateStats(dragonDamage, dragonHealth, dragonArmor);
    }
    

}
foreach (var item in colors)
{
    Console.WriteLine(item);
    foreach (var i in item.Dragons.OrderBy(x=>x.Name))
    {
        Console.WriteLine(i);
    }
}
;
public class Dragon
{
    public Dragon(string color, string name, int damage, int health, int armor)
    {
        Color = color;
        Name = name;
        Damage = damage;
        Health = health;
        Armor = armor;
    }

    public string Color { get; set; }
    public string Name { get; set; }
    public int Damage { get; set; }
    public int Health { get; set; }
    public int Armor { get; set; }
    public void UpdateStats(int damage,int health , int armor)
    {
        this.Damage = damage;
        this.Health = health;
        this.Armor = armor;
    }
    public override string ToString()
    {
        return $"-{this.Name} -> damage: {this.Damage}, health: {this.Health}, armor: {this.Armor}";
    }
}
public class Color
{
    public string Name { get; set; }
    public List<Dragon> Dragons { get; set; } = new List<Dragon>();
    public Color(Dragon dragon)
    {
        this.Name = dragon.Color;
        this.Dragons.Add(dragon);
    }
    public override string ToString()
    {//"{Type}::({damage}/{health}/{armor})".
        return $"{this.Name}::({this.Dragons.Average(x => x.Damage):f2}/{this.Dragons.Average(x => x.Health):f2}/{this.Dragons.Average(x => x.Armor):f2})";
    }
}