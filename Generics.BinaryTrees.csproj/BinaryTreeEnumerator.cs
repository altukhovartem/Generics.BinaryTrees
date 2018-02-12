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
        private BinaryTree<T> Node { get; set; }
        private BinaryTree<T> Parent { get; set; }
        object IEnumerator.Current => Current;
        public T Current { get; set; }

        bool GoToLeft = true;
        bool GoToRight = true;

        public BinaryTreeEnumerator(BinaryTree<T> node)
        {
            if (node == null)
                throw new Exception();
            this.Node = node;
        }

        public bool MoveNext()
        {
            while (true)
            {
                while (GoToLeft)
                {
                    if (Node.Left.HasValue == true)
                    {
                        Parent = Node;
                        Node = Node.Left;
                    }
                    else
                        GoToLeft = false;
                }
                
                if (Node.Right.HasValue == true)
                {
                    Parent = Node;
                    Node = Parent.Right;
                    GoToLeft = true;
                }

                
                else
                {
                    GoToRight = false;
                    Current = Node.Value;
                    Node = Parent;
                    Parent = Node.Parent;
                    
                    return true;
                }
      
                
                
            }
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
