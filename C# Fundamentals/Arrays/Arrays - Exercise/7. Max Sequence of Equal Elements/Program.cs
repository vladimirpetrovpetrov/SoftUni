var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

int startingIndex = 0;
int endIndex = 0;
int number = 0;
int biggestSeq = 1;
int biggestSeqATM = 1;


for (int i = 0; i < arr.Length; i++)
{


	for (int j = i + 1; j < arr.Length; j++)
	{
		if (arr[i] == arr[j])
		{
			biggestSeqATM++;
			if (biggestSeqATM > biggestSeq)
			{
				biggestSeq = biggestSeqATM;
				startingIndex = i;
				endIndex = j;
				number = arr[i];
			}
		}
		else {
            biggestSeqATM = 1; break; }
	}
	biggestSeqATM = 1;
}

for (int i = 0; i < biggestSeq; i++)
{
	Console.Write(number + " ");
}