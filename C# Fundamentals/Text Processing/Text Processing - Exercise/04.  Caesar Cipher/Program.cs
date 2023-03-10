var input = Console.ReadLine().ToCharArray();

for (int i = 0; i < input.Length; i++)
{
    int newValue = input[i] + 3;
    input[i] = (char)newValue;
}
string result = new string(input);
Console.WriteLine(result);