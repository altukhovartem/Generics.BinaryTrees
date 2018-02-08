using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.BinaryTrees
{
    class BinaryTreeEnumerator<T> : IEnumerator<T> 
        where T : IComparable
    {
        public T Current => throw new NotImplementedException();

        object IEnumerator.Current => Current;

        public BinaryTreeEnumerator(BinaryTree<T> node)
        {

        }

        public void Dispose()
        {
            Dispose();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
