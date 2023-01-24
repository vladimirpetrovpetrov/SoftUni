using System;

namespace Drawing_with_Recursion
{
    internal class Program
    {
        static void Print(int index)
        {
            if (index == 0)
            {
                return;
            }

            Console.WriteLine(new String('*', index));

            Print(index - 1);
            Console.WriteLine(new String('#', index));
        }
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            Print(n);
        }
    }
}
