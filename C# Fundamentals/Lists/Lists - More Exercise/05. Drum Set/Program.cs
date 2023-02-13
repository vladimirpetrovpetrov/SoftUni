double savings = double.Parse(Console.ReadLine()!);
var qualityOfDrums = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
var initialQualities = qualityOfDrums; 

while (5 == 5)
{
    var input = Console.ReadLine();
    if(input == "Hit it again, Gabsy!")
    {
        break;
    }
    int hitPower = int.Parse(input!);
   qualityOfDrums=  qualityOfDrums.Select(x => x - hitPower).ToList();
    for (int i = 0; i < qualityOfDrums.Count; i++)
    {
        if (qualityOfDrums[i] <= 0)
        {
            int price = initialQualities[i] * 3;
            if (savings >= price)
            {
                savings -= price;
                qualityOfDrums[i] = initialQualities[i];
            }
            else
            {
                qualityOfDrums.RemoveAt(i);
                initialQualities.RemoveAt(i);
            }
        }
    }
}
Console.WriteLine(String.Join(" ",qualityOfDrums));
Console.WriteLine($"Gabsy has {savings:f2}lv.");