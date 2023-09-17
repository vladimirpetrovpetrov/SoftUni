using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomNumberEnumerator
{
    public class NumberEnumerator : IEnumerator<int>
    {
        private int element = 0;
        public int Current
        {
            get { return element; }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            element++;
            return true;

        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
