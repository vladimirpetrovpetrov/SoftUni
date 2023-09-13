namespace CustomStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomStack customStack= new CustomStack();

            customStack.Push(1);
            customStack.Push(2);
            customStack.Push(3);
            customStack.Push(4);
            customStack.Push(5);

            Console.WriteLine(customStack.Pop());
            Console.WriteLine(customStack.Pop());
            Console.WriteLine(customStack.Pop());

            Console.WriteLine(customStack.Peek());
            

            customStack.ForEach(x => Console.WriteLine(x));
        }
    }
}