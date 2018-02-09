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
        object IEnumerator.Current => Current;
        public T Current => new BinaryTree<T>().Value;

        public BinaryTreeEnumerator(BinaryTree<T> node)
        {
            if (node == null)
                throw new Exception();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Dispose();
        }
    }
}
