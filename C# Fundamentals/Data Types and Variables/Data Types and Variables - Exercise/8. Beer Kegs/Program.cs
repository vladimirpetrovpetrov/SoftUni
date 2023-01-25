// π * r^2 * h 

var totalKegs = int.Parse(Console.ReadLine());
string biggestKegName = " ";
double biggestKegVolume = double.MinValue;
double volume = 0;


for(int i = 0;i < totalKegs; i++)
{
    var name = Console.ReadLine();
    var radius = double.Parse(Console.ReadLine());
    var height = double.Parse(Console.ReadLine());
    volume = Math.PI * radius*radius*height;
    if (volume > biggestKegVolume)
    {
        biggestKegVolume = volume;
        biggestKegName = name;
    }
}
Console.WriteLine(biggestKegName);