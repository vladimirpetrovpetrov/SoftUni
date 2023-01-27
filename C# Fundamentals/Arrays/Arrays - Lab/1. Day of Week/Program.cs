string[] daysOfTheWeek = new string[7];

daysOfTheWeek[0] = "Monday";
daysOfTheWeek[1] = "Tuesday";
daysOfTheWeek[2] = "Wednesday";
daysOfTheWeek[3] = "Thursday";
daysOfTheWeek[4] = "Friday";
daysOfTheWeek[5] = "Saturday";
daysOfTheWeek[6] = "Sunday";


var n = int.Parse(Console.ReadLine());
if (n >= 1 && n <= 7)
{
    Console.WriteLine(daysOfTheWeek[n - 1]);
}
else
{
    Console.WriteLine("Invalid day!");
}