using System;

class InstructionSet_broken
{
    static void Main()
    {

        long result = 0;
        while (true)
        {
            string opCode = Console.ReadLine();
            if (opCode == "END")
            {
                return;
            }
            string[] codeArgs = opCode.Split(' ', StringSplitOptions.RemoveEmptyEntries);


            switch (codeArgs[0])
            {
                //check if it needs to be BigInteger
                case "INC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = ++operandOne;
                        Console.WriteLine(result);
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = --operandOne;
                        Console.WriteLine(result);
                        break;
                    }
                case "ADD":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        Console.WriteLine(result);
                        break;
                    }
                case "MLA":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne * operandTwo;
                        Console.WriteLine(result);
                        break;
                    }
            }
        }
    }
}

//using System;

//class InstructionSet_broken
//{
//    static void Main()
//    {
//        string opCode = Console.ReadLine();

//        while (opCode != "end")
//        {
//            string[] codeArgs = opCode.Split(' ');

//            long result = 0;
//            switch (codeArgs[0])
//            {
//                case "INC":
//                    {
//                        int operandOne = int.Parse(codeArgs[1]);
//                        result = operandOne++;
//                        break;
//                    }
//                case "DEC":
//                    {
//                        int operandOne = int.Parse(codeArgs[1]);
//                        result = operandOne--;
//                        break;
//                    }
//                case "ADD":
//                    {
//                        int operandOne = int.Parse(codeArgs[1]);
//                        int operandTwo = int.Parse(codeArgs[2]);
//                        result = operandOne + operandTwo;
//                        break;
//                    }
//                case "MLA":
//                    {
//                        int operandOne = int.Parse(codeArgs[1]);
//                        int operandTwo = int.Parse(codeArgs[2]);
//                        result = (long)(operandOne * operandTwo);
//                        break;
//                    }
//            }

//            Console.WriteLine(result);
//        }
//    }
//}