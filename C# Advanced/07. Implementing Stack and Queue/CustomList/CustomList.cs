using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomList;

public class CustomList
{
    private const int InitialCapacity = 2;
    private int[] items;
    public int Count { get; private set; }
    public int this[int index]
    {
        get
        {
            ThrowExceptionIfIndexOutOfRange(index);
            return this.items[index];
        }
        set
        {
            ThrowExceptionIfIndexOutOfRange(index);
            items[index] = value; 
        }
    }

    
    public CustomList()
    {
        items = new int[InitialCapacity];
        this.Count = 0;
    }

    public void Add(int value)
    {
        if(this.items.Length == this.Count)
        {
            Resize();
        }
        this.items[Count] = value;
        this.Count++;

    }
    public int RemoveAt(int index)
    {
        ThrowExceptionIfIndexOutOfRange(index);
        int removedItem = this.items[index];
        ShiftLeft(index);
        Count--;
        if(items.Length / 4 >= Count)
        {
        Shrink();
        }
        return removedItem;

    }


    public void InsertAt(int index,int value)
    {
        ThrowExceptionIfIndexOutOfRange(index);//proverka
        if (this.items.Length == this.Count)
        {
            Resize();
        }
        ShiftRight(index);
        items[index] = value;
        Count++;

    }
    public bool Contains(int value)
    {
        for (int i = 0; i < Count; i++)
        {
            if (items[i] == value)
            {
                return true;
            }
        }
        return false;
    }
    public void Swap(int indexOne, int indexTwo)
    {
        ThrowExceptionIfIndexOutOfRange(indexOne);
        ThrowExceptionIfIndexOutOfRange(indexTwo);
        int temp = this.items[indexOne];
        items[indexOne] = items[indexTwo];
        items[indexTwo] = temp;

    }
    public void ForEach(Action<int> action)
    {
        for (int i = 0; i < Count; i++)
        {
            int currentItem = items[i];
            action(currentItem);
        }
    }
    public void AddRange(int[] items)
    {
        foreach (var item in items)
        {
            Add(item);
        }
    }

    private void Resize()
    {
        int[] copy = new int[items.Length * 2];

        for (int i = 0; i < Count; i++)
        {
            copy[i] = items[i];
        }

        items = copy;


    }
    private void ThrowExceptionIfIndexOutOfRange(int index)
    {
        if(index<0 || index >= Count)
        {
            throw new IndexOutOfRangeException("Invalid index");
        } 
    }
    private void ShiftLeft(int index)
    {
        for (int i = index; i < Count - 1; i++)
        {
            items[i] = items[i + 1];
        }
    }
    private void ShiftRight(int index)
    {
        for (int i = Count-1; i >= index; i--)
        {
            items[i+1] = items[i];
        }
    }
    private void Shrink()
    {
        int[] copy = new int[items.Length / 2];

        for (int i = 0; i < Count; i++)
        {
            copy[i] = items[i];
        }

        items = copy;
    }

}
