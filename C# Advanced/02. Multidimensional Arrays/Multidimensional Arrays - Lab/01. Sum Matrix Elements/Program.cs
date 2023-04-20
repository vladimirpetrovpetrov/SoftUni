var rowsCols = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
var rows = rowsCols[0];
var cols = rowsCols[1];
int[][] matrix = new int[rows][];
var sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
	matrix[i] = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
	sum += matrix[i].Sum();
}
Console.WriteLine(matrix.GetLength(0));
Console.WriteLine(matrix[0].Length);
Console.WriteLine(sum);



