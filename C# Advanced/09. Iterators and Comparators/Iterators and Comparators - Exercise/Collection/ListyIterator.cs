using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection;

public class ListyIterator<T> : IEnumerable<T>
{
    private List<T> list;
    private int index = 0;

    public ListyIterator(List<T> list)
    {
        this.list = list;
    }

    public bool Move()
    {
        if(index < list.Count - 1)
        {
            index++;
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool HasNext()
    {
        if(index < list.Count - 1)
        {
            return true;
        }
        else 
        { 
            return false;
        }
    }

    public void Print()
    {
        if(list.Count == 0) 
        {
            throw new InvalidOperationException("Invalid Operation!");
        }
        Console.WriteLine(list[index]);
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in this.list)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
