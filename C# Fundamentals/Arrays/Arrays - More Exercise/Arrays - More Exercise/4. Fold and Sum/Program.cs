int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
int k = 0;

int[] leftArr = new int[ints.Length / 4];
int[] rightArr = new int[ints.Length / 4];

for (int i = 0;i < leftArr.Length; i++)
{
    leftArr[i] = ints[i];
}
for (int i = ints.Length-1; i > (ints.Length-1) - rightArr.Length ; i--)
{
    rightArr[k] = ints[i];
    k++;
}
k = 0;
Array.Reverse(leftArr);
int[] firstRow = new int[ints.Length / 2];
for (int i = 0; i < firstRow.Length/2; i++)
{
    firstRow[i] = leftArr[i];
}
for (int i = firstRow.Length/2; i <= firstRow.Length-1; i++)
{
    firstRow[i] = rightArr[k];
    k++;
}
int[] secondRow = new int[ints.Length / 2];
Array.Copy(ints,leftArr.Length,secondRow,0,secondRow.Length);
int[] result = new int[secondRow.Length];

for (int i = 0; i < secondRow.Length; i++)
{
    result[i] = firstRow[i] + secondRow[i];
}

Console.WriteLine(String.Join(" ",result));