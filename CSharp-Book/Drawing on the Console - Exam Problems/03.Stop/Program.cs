using System;

namespace Stop_sign_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //var n = 3;

            var dots = n;
            //first row
            Console.Write(new string('.', dots + 1));
            Console.Write(new string('_', n * 2 + 1));
            Console.WriteLine(new string('.', dots + 1));

            //upper part

            var dash = n * 2 - 1;
            for (int row = 0; row < n; row++)
            {

                Console.Write(new string('.', dots));
                Console.Write("//");
                Console.Write(new string('_', dash));
                Console.Write("\\\\");
                Console.Write(new string('.', dots));
                Console.WriteLine();
                dots--;
                dash++;
                dash++;
            }

            //"STOP" part

            Console.Write("//");
            Console.Write(new string('_', ((dash - 5) / 2)));
            Console.Write("STOP!");
            Console.Write(new string('_', ((dash - 5) / 2)));
            Console.WriteLine("\\\\");

            //lower part 
            dots = 0;
            dash = dash;
            for (int row = 0; row < n; row++)
            {

                Console.Write(new string('.', dots));
                Console.Write("\\\\");
                Console.Write(new string('_', dash));
                Console.Write("//");
                Console.Write(new string('.', dots));
                Console.WriteLine();
                dots++;
                dash--;
                dash--;
            }

        }
    }
}