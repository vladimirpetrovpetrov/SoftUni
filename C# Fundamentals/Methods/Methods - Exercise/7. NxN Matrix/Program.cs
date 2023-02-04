int num = int.Parse(Console.ReadLine());
PrintMatrix(num);




static void Cols(int num)
{
    for (int k = 0; k < num; k++)
    {
        Console.Write(num + " ");
    }
}
static void Rows(int num)
{
    for (int j = 0; j < num; j++)
    {
        Cols(num);
        Console.WriteLine();
    }
}
static void PrintMatrix(int num)
{
    Rows(num);
}