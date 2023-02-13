using System.Globalization;
using System.Security.Cryptography.X509Certificates;

string s = Console.ReadLine();

List<int> nums = new List<int>();
List<char> nonNums = new List<char>();

foreach (var item in s)
{
    
    if (Char.IsDigit(item))
    {
        int x = int.Parse(item.ToString());
        nums.Add(x);
    }
    else
    {
        nonNums.Add(item);
    }
}

List<int> take = new List<int>();
List<int> skip = new List<int>();

for (int i = 0; i < nums.Count; i++)
{
    if (i % 2 == 0)
    {
        take.Add(nums[i]);
    }
    else
    {
        skip.Add(nums[i]);
    }
}
int skipCount = 0;
string finalResultString = "";
for (int i = 0; i < take.Count; i++)
{

    List<char> finalResult= nonNums.Skip(skipCount).Take(take[i]).ToList();
    finalResultString += String.Join("", finalResult);
    skipCount = skipCount + skip[i] + take[i];

}
Console.WriteLine(finalResultString);