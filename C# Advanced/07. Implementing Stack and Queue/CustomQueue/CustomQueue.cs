using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQueue;

public class CustomQueue
{
    const int InitialCapacity = 4;
    private int[] items;

    public CustomQueue()
    {
        this.items = new int[InitialCapacity];
        Count = 0;
    }

    public int Count { get; private set; }

    public void Enqueue(int item)
    {
        if (Count == items.Length)
        {
            Resize();
        }
        if(Count== 0)
        {
            items[0] = item;
        }
        else
        {
            ShiftRight();
            items[0] = item;
        }
        Count++;
    }

    public int Dequeue()
    {
        if(Count == 0)
        {
            throw new Exception("Queue is empty!");
        }
        int removedItem = this.items[Count-1];
        Count--;
        if (items.Length / 4 >= Count && Count != 0)
        {
            Shrink();
        }
        return removedItem;

    }
    public int Peek()
    {
        if (Count == 0)
        {
            throw new Exception("Queue is empty!");
        }
        return this.items[Count-1];
    }

    public void Clear()
    {
        Count= 0;
        items = new int[InitialCapacity];
    }

    public void ForEach(Action<int> action)
    {
        for (int i = Count-1; i >= 0; i--)
        {
            int currentItem = items[i];
            action(currentItem);
        }
    }
    private void ShiftRight()
    {
        for (int i = Count; i > 0; i--)
        {
            this.items[i] = this.items[i - 1];
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
    private void Shrink()
    {
        int[] copy = new int[this.items.Length / 2];
        for (int i = 0; i < Count; i++)
        {
            copy[i] = this.items[i];
        }
        this.items = copy;
    }
}
