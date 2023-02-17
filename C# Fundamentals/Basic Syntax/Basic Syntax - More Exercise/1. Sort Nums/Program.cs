var n = int.Parse(Console.ReadLine());
var n2 = int.Parse(Console.ReadLine());
var n3 = int.Parse(Console.ReadLine());

int[] nums = new int[3];
nums[0] = n;
nums[1] = n2;
nums[2] = n3;

Array.Sort(nums);
Array.Reverse(nums);


foreach(int i in nums)
{
    Console.WriteLine(i);
}