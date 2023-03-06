using System.Security.Cryptography.X509Certificates;

List<Dwarf> dwarfs = new List<Dwarf>();
List<Color> colors = new List<Color>(); //ще проверява дали имаме даден цвят и ако го имаме ще му увеличава бройката , а няма да го добавя, ако го нямаме , ще го добавя с бройка 1
while (true)
{
    var input = Console.ReadLine()!;
    if (input == "Once upon a time")
    {
        break;
    }
    var command = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
    var dwarfName = command[0];
    var dwarfColor = command[1];
    var dwarfPhysics = int.Parse(command[2]);

    bool nameExist = dwarfs.Any(x => x.Name == dwarfName); //дали съществува гном с такова име
    bool colorExist = dwarfs.Any(x => x.Color.Name == dwarfColor); //дали съществува гном с такъв цвят

    if (!nameExist && !colorExist) // ако нито имаме такова име , нито имаме такъв цвят ВЪОБЩЕ
    {
        Color color = new Color(dwarfColor, 1); //създаваме нов цвят
        colors.Add(color); //добавяме го към листатата с цветове
        Dwarf dwarf = new Dwarf(dwarfName, dwarfPhysics, color); //създаваме нов гном 
        dwarfs.Add(dwarf); //добавяме гнома към листата с гномове
    }
    else if (!nameExist && colorExist)// - + 
    {
        //първо трябва да намерим цвета в листа и да му увеличим бройката
        var colorToIncremenent = colors.Find(x => x.Name == dwarfColor);
        colorToIncremenent.Times++;
        //после създаваме нов гном
        Dwarf dwarf = new Dwarf(dwarfName, dwarfPhysics, colorToIncremenent);
        dwarfs.Add(dwarf);

    }
    else if (nameExist && colorExist) // + +
    {
        var originalDwarfCheck = dwarfs.Find(x => x.Name == dwarfName);
        var sameNameSameColor = false;
        if(originalDwarfCheck.Color.Name == dwarfColor)
        {
            sameNameSameColor= true;
        }
        if (sameNameSameColor) //еднакво име , еднакъв цвят и самият цвят съществува
        {
            var originalDwarf = dwarfs.Find(x => x.Name == dwarfName);
            if (dwarfPhysics > originalDwarf.Physics) //ако числата на новия гном са по-големи, реплейсваме стария
            {
                originalDwarf.Physics = dwarfPhysics;
            }
        }
        else if (!sameNameSameColor)//еднакво име , различен цвят и самият цвят съществува
        {
            var colorToIncremenent = colors.Find(x => x.Name == dwarfColor);
            colorToIncremenent.Times++;
            //после създаваме нов гном
            Dwarf dwarf = new Dwarf(dwarfName, dwarfPhysics, colorToIncremenent);
            dwarfs.Add(dwarf);
        }
    }
    else if (nameExist && !colorExist) //+ - 
    {
        //ако има гном с такова име вече 
        //и цвета му не е като на новия
        Color color = new Color(dwarfColor, 1); //създаваме нов цвят
        colors.Add(color); //добавяме го към листатата с цветове
        Dwarf dwarf = new Dwarf(dwarfName, dwarfPhysics, color); //създаваме нов гном 
        dwarfs.Add(dwarf); //добавяме гнома към листата с гномове

    }
}

//"({hatColor}) {name} <-> {physics}"
//You must order the dwarfs by physics in descending order and then by the total count of dwarfs with the same hat color in descending order. 
//Then you must print them all. 

dwarfs = dwarfs.OrderByDescending(x => x.Physics).ThenByDescending(x => x.Color.Times).ToList();


foreach (var item in dwarfs)
{
    Console.WriteLine($"({item.Color}) {item.Name} <-> {item.Physics}");
}
public class Dwarf
{
    public string Name { get; set; }
    public Color Color { get; set; }
    public int Physics { get; set; }



    public Dwarf(string name, int physics, Color color)
    {
        Name = name;
        Physics = physics;
        Color = color;

    }
}
public class Color
{
    public Color(string name, int times)
    {
        Name = name;
        Times = times;
    }

    public string Name { get; set; }
    public int Times { get; set; }
    //при всяко извикване да се покачва таймс с 1
    public override string ToString()
    {
        return $"{this.Name}";
    }


}
