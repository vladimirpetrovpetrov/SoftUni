 namespace CustomQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomQueue queue = new CustomQueue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());

            queue.ForEach(x => Console.WriteLine(x));
            queue.Clear();

            Console.WriteLine(queue.Count);
            ;
        }
    }
}