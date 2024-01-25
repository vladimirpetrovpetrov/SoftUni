using System;

namespace Операции_между_числа
{
    class Program
    {
        static void Main(string[] args)
        {

            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            char operatorX = Convert.ToChar(Console.ReadLine());


            //TODO - форматирай до 2 знак след запетая


            switch (operatorX)
            {
                case '+':
                    if ((num1 + num2) % 2 == 0)
                    {
                        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2) + " - even");
                    }
                    else
                    {
                        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2) + " - odd");
                    }
                    break;
                case '-':
                    if ((num1 - num2) % 2 == 0)
                    {
                        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2) + " - even");
                    }
                    else
                    {
                        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2) + " - odd");
                    }
                    break;
                case '*':
                    if ((num1 * num2) % 2 == 0)
                    {
                        Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2) + " - even");
                    }
                    else
                    {
                        Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2) + " - odd");
                    }

                    break;

                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide " + num1 + " by zero");
                    }
                    else
                    {
                        var num1D = Convert.ToDouble(num1);
                        var num2D = Convert.ToDouble(num2);
                        var result = num1D / num2D;
                        Console.WriteLine(num1 + " / " + num2 + " = " + String.Format("{0:0.00}", result));
                    }
                    break;
                case '%':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide " + num1 + " by zero");
                    }
                    else
                    {
                        var num1D = Convert.ToDouble(num1);
                        var num2D = Convert.ToDouble(num2);
                        var result = num1D % num2D;
                        Console.WriteLine(num1 + " % " + num2 + " = " + result);
                    }


                    break;
            }
        }
    }
}
