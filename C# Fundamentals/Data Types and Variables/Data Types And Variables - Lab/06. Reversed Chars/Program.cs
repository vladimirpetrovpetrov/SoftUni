char[] charArr = new char[3];
for(int i = 0; i < 3; i++)
{
    charArr[i] = char.Parse(Console.ReadLine());
}
Console.WriteLine(String.Join(" ",charArr.Reverse()));