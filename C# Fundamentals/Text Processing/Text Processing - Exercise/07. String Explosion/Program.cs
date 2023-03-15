var input = Console.ReadLine();
var additional = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '>')
    {
        var startingIndex = i;
        var str = int.Parse(input[i+1].ToString());
        var length = str + additional;
        for (int j = 0; j < length; j++)
        {
            if (input.Length - 1 >= startingIndex + 1)
            {
                if (input[startingIndex + 1] != '>')
                {
                    input = input.Remove(startingIndex + 1, 1);
                    additional = 0;
                }
                else
                {
                    additional = str - j;
                    break;
                }
            }
            else
            {
                break;
            }
        }
    }
}
Console.WriteLine(input);