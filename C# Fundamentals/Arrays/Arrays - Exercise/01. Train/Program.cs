var wagons = int.Parse(Console.ReadLine());
int[] passengersCount = new int[wagons];

for (int i = 0;i < wagons; i++)
{
    passengersCount[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine(String.Join(" ",passengersCount));
Console.WriteLine(passengersCount.Sum());