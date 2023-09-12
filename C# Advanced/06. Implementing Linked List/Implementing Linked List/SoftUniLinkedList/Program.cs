namespace SoftUniLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList linkedList = new CustomLinkedList();

            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddFirst(0);
            linkedList.AddFirst(-1);
            linkedList.AddFirst(-2);
            linkedList.AddFirst(-3);

            linkedList.RemoveFirst();
            linkedList.RemoveFirst();

            linkedList.RemoveLast();

            linkedList.ForEach(x => Console.WriteLine(x.Value));




            Node currentNode = linkedList.Head;
            while(currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next; 
            }


        }
    }
}