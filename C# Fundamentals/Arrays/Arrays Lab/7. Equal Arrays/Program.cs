var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
var arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();


int sum = 0;

for(int i = 0;i < arr1.Length; i++)
{
    if (arr[i] != arr1[i]) 
    { 
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        return;
    }
    sum += arr[i];
}
Console.WriteLine($"Arrays are identical. Sum: {sum}");
