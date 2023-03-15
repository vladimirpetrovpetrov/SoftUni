using System;
using System.Text;

namespace _03._Unicode_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var input = Console.ReadLine();
            var result = ConvertToUtf(input).ToCharArray();
            for (int i = 0; i < result.Length; i++)
            {
                if (Char.IsLetter(result[i]) && Char.IsUpper(result[i]))
                {
                    result[i] = Char.ToLower(result[i]);
                }
            }
            Console.WriteLine(String.Join("",result));
        }
        static string ConvertToUtf(string input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in input)
            {
                sb.AppendFormat("\\u{0:X4}", (uint)c);
            }
            return sb.ToString();
        }
    }
}
