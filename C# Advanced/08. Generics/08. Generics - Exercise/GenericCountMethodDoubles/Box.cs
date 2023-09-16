using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodDoubles;

public class Box<T> where T : IComparable<T>
{
    private List<T> values;

    public Box()
    {
        this.values = new List<T>();
    }

    public int CountGreater(T value)
    {
        int count = 0;
        foreach (T item in this.values)
        {
            if(item.CompareTo(value) > 0)
            {
                count++;
            }
        }
        return count;
    }

    public void AddElement(T value)
    {
        this.values.Add(value);
    }

    public override string ToString()
    {
        StringBuilder st = new StringBuilder();
        foreach (var item in values)
        {
            st.AppendLine($"{item.GetType()}: {item}");
        }
        return st.ToString().Trim();
    }
}
