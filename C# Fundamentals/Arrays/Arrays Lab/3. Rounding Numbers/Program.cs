var arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
int[] intArr = new int[arr.Length];

for (int i = 0;i < arr.Length; i++)
{
    intArr[i] = (int)Math.Round(arr[i],MidpointRounding.AwayFromZero);
}
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"{arr[i]} => {intArr[i]}");
}

