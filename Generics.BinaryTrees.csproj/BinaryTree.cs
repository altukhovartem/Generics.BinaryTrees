using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.BinaryTrees
{
    public class BinaryTree<T> : IEnumerable
        where T:IComparable
    {
        public BinaryTree<T> Left { get; set; }
        public BinaryTree<T> Right { get; set; }
        public T Value { get; set; }
        private bool DoesNotHaveValue = true;


        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        
        public void Add(T value)
        {
            if (DoesNotHaveValue)
            {
                this.Value = value;
                DoesNotHaveValue = false;
                Left = new BinaryTree<T>();
                Right = new BinaryTree<T>();
            }
            else
            {
                if (value.CompareTo(this.Value) == 1)
                {
                    Insert(value, Right);
                }
                if (value.CompareTo(this.Value) == -1)
                {
                    Insert(value, Left);
                }
            }


        }

        private void Insert(T value, BinaryTree<T> currentNode)
        {
            if (currentNode.DoesNotHaveValue)
            {
                currentNode = new BinaryTree<T>();
                currentNode.Value = value;
                DoesNotHaveValue = false;
            }
            else
            {
                if (currentNode.Value.CompareTo(value) == 1)
                    Insert(value, currentNode.Right);

                else if (currentNode.Value.CompareTo(value) == -1)
                    Insert(value, currentNode.Left);
            }

        }
    }
}


