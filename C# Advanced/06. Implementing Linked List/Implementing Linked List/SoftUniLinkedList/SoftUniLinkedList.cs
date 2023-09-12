using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLinkedList
{
    public class CustomLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public void ForEach(Action<Node> action)
        {
            Node node = Head;

            while (node != null)
            {
                action(node);
                node = node.Next;
            }
        }
        public void AddLast(int value)
        {
            Node node = new Node(value);
            if(Tail == null)
            {
                Head = node;
                Tail = node;
                return;
            }

            Tail.Next = node;
            node.Previous = Tail;
            Tail = node;
        }

        public void AddFirst(int value)
        {
            Node node = new Node(value);
            if(Head == null)
            {
                Head = node; 
                Tail = node;
                return;
            }
            Head.Previous = node;
            node.Next = Head;
            Head = node;
        }

        public void RemoveFirst()
        {
            if (Head.Next != null)
            {
                Node newHead = Head.Next;
                newHead.Previous = null;
                Head.Next = null;
                Head = newHead;
            }
            else
            {
                Head = null;
                Tail = null;
            }

        }

        public void RemoveLast()
        {
            if(Tail.Previous == null)
            {
                Head = null;
                Tail = null;
            }
            Node newTail = Tail.Previous;
            newTail.Next = null;
            Tail.Previous = null;
            Tail = newTail;
        }


    }
}
