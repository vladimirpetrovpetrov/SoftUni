var n = int.Parse(Console.ReadLine());


int[] ints= new int[n];
for (int i = 0;i < n; i++)
{
    int num  = int.Parse(Console.ReadLine());
    ints[ints.Length - 1 - i] = num;
}

Console.WriteLine(String.Join(" ",ints));