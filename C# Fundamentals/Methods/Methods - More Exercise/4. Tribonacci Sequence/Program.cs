int numbers = int.Parse(Console.ReadLine());
int f1 = 1;
int f2 = 1;
int f3 = 2;
int fNext = 0;
List<int> list = new List<int>{1,1,2};
if(numbers < 3)
{
    for (int i = 0; i < numbers; i++)
    {
        Console.Write(list[i] + " ");
        
    }
    return;
}
for (int i = 0; i < numbers-3; i++)
{
    fNext = f1 + f2 + f3;
    list.Add(fNext);
    f1 = f2;
    f2 = f3;
    f3 = fNext;
}
Console.WriteLine(String.Join(" ",list));
