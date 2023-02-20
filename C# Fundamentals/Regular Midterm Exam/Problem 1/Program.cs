var days = int.Parse(Console.ReadLine());
var players = int.Parse(Console.ReadLine());
var energy = double.Parse(Console.ReadLine());
var waterPerPerson = double.Parse(Console.ReadLine());
var foodPerPerson = double.Parse(Console.ReadLine());

var foodPerWholeQuest= foodPerPerson * players * days; //water for all per quest
var waterPerWholeQuest = waterPerPerson * players*days; //food for all per quest

for (int i = 1; i <= days; i++)
{
    var energyLoss = double.Parse(Console.ReadLine());

    energy -= energyLoss;
    if(energy<= 0)
    {
        Console.WriteLine($"You will run out of energy. You will be left with {foodPerWholeQuest:f2} food and {waterPerWholeQuest:f2} water.");
        return;
    }
    if (i % 2 == 0)
    {
        energy *= 1.05;
        waterPerWholeQuest *= 0.70;
    }
    if (i % 3 == 0)
    {
        foodPerWholeQuest -= foodPerWholeQuest / players;
        energy *= 1.10;
    }
}
Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");