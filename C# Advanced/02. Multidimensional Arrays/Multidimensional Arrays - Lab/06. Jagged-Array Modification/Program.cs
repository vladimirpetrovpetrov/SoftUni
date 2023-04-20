var rows = int.Parse(Console.ReadLine());   
int[][] jaggedArray = new int[rows][];

for (int row = 0; row < jaggedArray.GetLength(0); row++)
{
    var rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    jaggedArray[row] = rowData;
}
while (true)
{
    var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (input[0] == "END")
    {
        break;
    }

    if (input[0] == "Add")
    {
        var row = int.Parse(input[1]);
        var col = int.Parse(input[2]);
        if(row < 0 || col < 0 || row >= jaggedArray.Length || col > jaggedArray[row].Length)
        {
            Console.WriteLine("Invalid coordinates");
            continue;
        }
        var newValue = int.Parse(input[3]);
        jaggedArray[row][col] += newValue;
    }else if (input[0] == "Subtract")
    {
        var row = int.Parse(input[1]);
        var col = int.Parse(input[2]);
        if (row < 0 || col < 0 || row >= jaggedArray.Length || col > jaggedArray[row].Length)
        {
            Console.WriteLine("Invalid coordinates");
            continue;
        }
        var newValue = int.Parse(input[3]);
        jaggedArray[row][col] -= newValue;
    }
}
for (int row = 0; row < jaggedArray.Length; row++)
{
    Console.WriteLine(String.Join(" ", jaggedArray[row]));
}