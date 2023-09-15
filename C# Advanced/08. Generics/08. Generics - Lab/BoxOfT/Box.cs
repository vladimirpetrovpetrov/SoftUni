using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        public List<T> List { get; set; } = new List<T>();
        public int Count { get; private set; } = 0;
        public void Add(T item)
        {
            this.List.Add(item);
            Count++;
        }
        public T Remove()
        {
            T lastElement = List.Last();
            List.Remove(lastElement);
            Count--;
            return lastElement;
        }
    }
}
