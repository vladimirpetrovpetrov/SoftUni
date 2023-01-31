int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
bool areEqual = false;

for(int i = 0;i < ints.Length; i++)
{
    int sumL = 0;
    int sumR = 0;
    for (int j = 0; j < i; j++)
    {
        sumL += ints[j];
    }
    for (int k = ints.Length-1; k > i; k--)
    {
        sumR += ints[k];
    }
    if(sumL == sumR)
    {
        areEqual = true;
        Console.WriteLine(i);
    }
}
if (!areEqual)
{
    Console.WriteLine("no");
}