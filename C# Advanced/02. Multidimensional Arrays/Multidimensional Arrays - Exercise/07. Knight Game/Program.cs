var n = int.Parse(Console.ReadLine());
var chess = new char[n,n];
for (int row = 0; row < n; row++)
{
	var input = Console.ReadLine().ToCharArray();
	for (int col = 0; col < n; col++)
	{
		chess[row,col] = input[col];
	}
}
;
//Try also with jagged array


