var n = int.Parse(Console.ReadLine());

int k = 1;
int v = 2;
int[] ints = CreateArray(v);
InitArray(ints);
if(n == 0)
{
    return;
}
else if(n == 1)
{
    Console.WriteLine(1);
    return;
}

Console.WriteLine(1);
Console.WriteLine(String.Join(" ",ints));
for (int i = 2; i < n; i++)
{
    v++;
    int[] intsNew = new int[v];
    InitArray(intsNew);

    for (int j = 1; j < ints.Length; j++)
    {
        intsNew[j] = ints[j-1] + ints[j];
    }
    
    ints = intsNew;
    Console.WriteLine(String.Join(" ", intsNew));

    
}


int[] CreateArray (int length)
{
    return new int[length];
}
void InitArray(int[] array)
{
    Array.Fill(array, 1);
}