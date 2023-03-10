var input = Console.ReadLine();

Console.WriteLine(String.Join("",input.Where(x=>Char.IsDigit(x))));
Console.WriteLine(String.Join("",input.Where(x=>Char.IsLetter(x))));
Console.WriteLine(String.Join("",input.Where(x=> !Char.IsDigit(x) && !Char.IsLetter(x))));
