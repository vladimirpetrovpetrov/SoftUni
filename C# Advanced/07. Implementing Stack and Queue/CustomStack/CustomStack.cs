using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    public class CustomStack
    {
        const int InitialCapacity = 4;
        private int[] items;

        public CustomStack()
        {
            this.items = new int[InitialCapacity];
            Count = 0;
        }

        public int Count { get;private set; }

        public void Push(int element)
        {
            if(Count >= items.Length)
            {
            Resize();
            }
            items[Count] = element;
            Count++;
        }

        

        public int Pop()
        {
            ThrowExceptionIfStackEmpty();
            int removedElement = items[Count-1];
            this.items[Count-1] = default;
            Count--;
            if(items.Length / 4 >= Count && Count != 0)
            {
                Shrink();
            }
            return removedElement;

        }

        private void ThrowExceptionIfStackEmpty()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }

        private void Shrink()
        {
            int[] copy = new int[this.items.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }
        public int Peek()
        {
            ThrowExceptionIfStackEmpty();
            return this.items[Count - 1];
        }
        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                int currentItem = items[i];
                action(currentItem);
            }
        }
        private void Resize()
        {
            int[] copy = new int[Count * 2];
            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }
            items = copy;
        }
    }
}
