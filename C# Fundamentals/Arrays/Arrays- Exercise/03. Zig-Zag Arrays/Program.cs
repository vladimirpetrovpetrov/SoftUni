var n = int.Parse(Console.ReadLine());

string[] arr = new string[n];
string[] arr1 = new string[n];

for (int i = 0; i < n; i++)
{
    var nums = Console.ReadLine().Split(" ");
    if (i % 2 == 0)
    {
        arr[i] = nums[0];
        arr1[i] = nums[1];
    }
    else
    {
        arr1[i] = nums[0];
        arr[i] = nums[1];
    }
    
}

Console.WriteLine(String.Join(" ",arr));
Console.WriteLine(String.Join(" ", arr1));
