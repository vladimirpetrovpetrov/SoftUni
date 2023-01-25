var startingYield = int.Parse(Console.ReadLine());



var totalYield = 0;
var days = 0;


while(startingYield >= 100)
{
    totalYield+= startingYield-26;
    days++;
    startingYield -= 10;
}
totalYield -= 26;
Console.WriteLine(days);
if (totalYield < 0)
{
    Console.WriteLine(0);
}
else
{
    Console.WriteLine(totalYield);
}