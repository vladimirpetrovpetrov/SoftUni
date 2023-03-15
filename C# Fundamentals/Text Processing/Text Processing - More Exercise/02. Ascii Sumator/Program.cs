var symbolOne = Char.Parse(Console.ReadLine());
var symbolTwo = Char.Parse(Console.ReadLine());
var text = Console.ReadLine().ToCharArray();
var sum = 0;


foreach (var item in text)
{
    if(item > symbolOne && item < symbolTwo)
    {
        sum += item;
    }
}
Console.WriteLine(sum);