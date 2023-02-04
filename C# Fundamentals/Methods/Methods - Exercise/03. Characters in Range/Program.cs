var charOne = char.Parse(Console.ReadLine());
var charTwo = char.Parse(Console.ReadLine());
if (charOne <= charTwo)
{
	PrintMissingChars(charOne,charTwo);
}
else
{ 
	PrintMissingChars(charTwo, charOne);
}





static void PrintMissingChars(char a,char b)
{
	for (char i = a; i < b; i++)
	{
		if(i == a)
		{
			continue;
		}
		Console.Write(i + " ");
	}
}