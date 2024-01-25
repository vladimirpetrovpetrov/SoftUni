using System;

namespace Modifikatori_za_dostap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.PI); //can access cuz is public
            //Console.WriteLine(Math.DI); //cant'access cuz private
            //Console.WriteLine(Math.MI); //can't access cuz protected
            MathTest.TellTheNumber(); 
        }
    }
    public class Math
    {
        public const double PI = 3.14;
        private const double DI = 8.15;
        protected const double MI = 1.111111;

    }
    public class MathTest : Math
    {
        public static void TellTheNumber()
        {
            Console.WriteLine(MathTest.PI); //can access cuz public
            //Console.WriteLine(MathTest.DI); //error cuz private
            Console.WriteLine(MathTest.MI); //can access when is protected
        }
    }
}
