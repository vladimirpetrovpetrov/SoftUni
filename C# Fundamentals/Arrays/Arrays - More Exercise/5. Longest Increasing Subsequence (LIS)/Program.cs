using System;

class LIS
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] tokens = input.Split(' ');
        int n = tokens.Length;
        int[] nums = new int[n];
        int[] len = new int[n];
        int[] prev = new int[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(tokens[i]);
            len[i] = 1;
            prev[i] = -1;

            for (int j = 0; j < i; j++)
            {
                if (nums[j] < nums[i] && len[j] + 1 > len[i])
                {
                    len[i] = len[j] + 1;
                    prev[i] = j;
                }
            }
        }

        int maxLen = 0;
        int maxPos = 0;

        for (int i = 0; i < n; i++)
        {
            if (len[i] > maxLen)
            {
                maxLen = len[i];
                maxPos = i;
            }
        }

        int[] lis = new int[maxLen];
        int k = maxLen - 1;

        while (maxPos != -1)
        {
            lis[k] = nums[maxPos];
            k--;
            maxPos = prev[maxPos];
        }

        Console.WriteLine(string.Join(" ", lis));
    }
}
