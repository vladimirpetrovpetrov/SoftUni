var hour = int.Parse(Console.ReadLine());

var min = int.Parse(Console.ReadLine());

min += 30;
if (min >= 60)
{
    hour++;
    min -= 60;
    if (hour > 23)
    {
        hour = 0;
    }
}

Console.WriteLine($"{hour}:{min:d2}");