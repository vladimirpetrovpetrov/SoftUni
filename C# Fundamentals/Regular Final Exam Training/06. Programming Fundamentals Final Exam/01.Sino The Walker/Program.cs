using System.Globalization;

var time = Console.ReadLine();
var steps = int.Parse(Console.ReadLine()) % 86400;
var secPerStep = int.Parse(Console.ReadLine()) % 86400;

var seconds = steps * secPerStep;

DateTime dt = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture);

var result = dt.AddSeconds(seconds).ToString("HH:mm:ss");

Console.WriteLine("Time Arrival: {0}", result);