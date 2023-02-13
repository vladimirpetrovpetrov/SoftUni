using System.ComponentModel.DataAnnotations;

int[] raceTrack = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x=> int.Parse(x)).ToArray();
int length = raceTrack.Length / 2;
int[] firstCar = raceTrack.Take(length).ToArray();
int[] secondCar = new int[length];
Array.Copy(raceTrack,length+1,secondCar,0,secondCar.Length);
Array.Reverse(secondCar);
double timeOne = 0;
double timeTwo = 0;
for (int i = 0; i < length; i++)
{
    timeOne += firstCar[i];
    if (firstCar[i] == 0)
    {
        timeOne *= 0.80;
    }
    timeTwo += secondCar[i];
    if (secondCar[i] == 0)
    {
        timeTwo *= 0.80;
    }
}

if (timeOne < timeTwo)
{
    Console.WriteLine($"The winner is left with total time: {timeOne}");
}
else
{
    Console.WriteLine($"The winner is right with total time: {timeTwo}");
}