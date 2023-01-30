var ints = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
bool greater = true;

for (int num = 0; num < ints.Length; num++)
{
	for (int i = num; i < ints.Length-1; i++)
	{
		if (ints[num] <= ints[i + 1])
		{
			greater = false;
			break;
		}
	}
	if (greater == true)
	{
		Console.Write(ints[num]+" ");
	}
	greater = true;
}




