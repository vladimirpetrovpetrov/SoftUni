var lines = int.Parse(Console.ReadLine());

for (int i = 0; i < lines; i++)
{
    var input = Console.ReadLine();
    int startIndexName = input.IndexOf('@') + 1;
    int endIndexName = input.IndexOf('|');
    int startIndexAge = input.IndexOf('#') + 1;
    int endIndexAge = input.IndexOf('*');
    var name = input.Substring(startIndexName, endIndexName - startIndexName);
    var age = input.Substring(startIndexAge, endIndexAge - startIndexAge);
    Console.WriteLine($"{name} is {age} years old.");
}