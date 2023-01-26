var lines = int.Parse(Console.ReadLine());
var openingBracket = false;
var balanced = false;
var nested = false;

for(int i = 0;i < lines; i++)
{

    var symbol = Console.ReadLine();
    
    if(openingBracket&& symbol == "(")
    {
        nested = true;
    }else if (!openingBracket &&symbol == "(")
    {
        openingBracket = true;
        balanced = false;
    }
    if (openingBracket && symbol == ")")
    {
        balanced = true;
        openingBracket= false;
    }
}
if (balanced && !nested)
{
    Console.WriteLine("BALANCED");
}
else
{
    Console.WriteLine("UNBALANCED");
}