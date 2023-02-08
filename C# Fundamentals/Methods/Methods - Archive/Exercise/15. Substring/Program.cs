using System;
using System.Text;

public class Substring_broken
{
    public static void Main()
    {
        var text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int extraSymbols = int.Parse(Console.ReadLine());
        bool hasP = false;

        for (int i = 0; i < text.Length; i++)
        {
            var x = text[i].ToCharArray();
            for (int j = 0; j < x.Length; j++)
            {
                if (x[j] == 'p')
                {
                    hasP = true;
                    StringBuilder result = new StringBuilder();
                    int extra = extraSymbols;
                    if (extra >= x.Length)
                    {
                        extra = x.Length - 1;
                    }
                    result.Append(x, j, extra + 1);
                    j += extraSymbols;
                    Console.WriteLine(result);
                }
            }
        }

        if (!hasP)
        {
            Console.WriteLine("no");
        }


    }
}






//using System;

//public class Substring_broken
//{
//    public static void Main()
//    {
//        string text = Console.ReadLine();
//        int jump = int.Parse(Console.ReadLine());

//        const char Search = 'р';
//        bool hasMatch = false;

//        for (int i = 0; i < text.Length; i++)
//        {
//            if (text[i] == Search)
//            {
//                hasMatch = true;

//                int endIndex = jump;

//                if (endIndex > text.Length)
//                {
//                    endIndex = text.Length;
//                }

//                string matchedString = text.Substring(i, endIndex);
//                Console.WriteLine(matchedString);
//                i += jump;
//            }
//        }

//        if (!hasMatch)
//        {
//            Console.WriteLine("no");
//        }
//    }
//}
