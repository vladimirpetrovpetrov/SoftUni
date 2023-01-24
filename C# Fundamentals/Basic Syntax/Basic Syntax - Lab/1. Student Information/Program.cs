string name = Console.ReadLine();
var age = int.Parse(Console.ReadLine());
var grade = double.Parse(Console.ReadLine());

Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:f2}");