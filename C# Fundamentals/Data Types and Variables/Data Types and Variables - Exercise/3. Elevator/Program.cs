var numberOfPeople = int.Parse(Console.ReadLine());
var capacityOfPeople = int.Parse(Console.ReadLine());
int fullCourses = 0;
fullCourses = numberOfPeople/ capacityOfPeople;

if (capacityOfPeople >= numberOfPeople)
{
    Console.WriteLine(1);
}else if (numberOfPeople>capacityOfPeople && numberOfPeople % capacityOfPeople != 0)
{
    Console.WriteLine($"{fullCourses+1}");
}
else
{
    Console.WriteLine(fullCourses);
}