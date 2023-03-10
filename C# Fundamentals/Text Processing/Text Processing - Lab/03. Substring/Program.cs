string toRemove = Console.ReadLine()!;
string input = Console.ReadLine()!;

while(true)
{
    int index = input.IndexOf(toRemove);
    if(index == -1)
    {
        break;
    }
    input = input.Remove(index,toRemove.Length);
    
}
Console.WriteLine(input);
