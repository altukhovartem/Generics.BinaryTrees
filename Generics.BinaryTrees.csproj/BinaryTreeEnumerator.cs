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
        public T Current => Head.Value;
        object IEnumerator.Current => Current;

        public BinaryTree<T> Head { get; set; }

        public BinaryTreeEnumerator(BinaryTree<T> node)
        {
            if (node == null)
                throw new Exception();
            Head = node;
        }

        public bool MoveNext()
        {
            
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
