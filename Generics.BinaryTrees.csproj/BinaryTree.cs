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
        public BinaryTree<T> Parent { get; set; }
        public BinaryTree<T> Left { get; set; }
        public BinaryTree<T> Right { get; set; }
        public T Value { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        
        public void Add(T value)
        {
            if (Parent == null)
            {
                this.Parent = new BinaryTree<T>();
                this.Value = value;
            }
            if(value.CompareTo(this.Value) == 1)
            {
                Insert(value, Right, this);
            }
            if (value.CompareTo(this.Value) == -1)
            {
                Insert(value, Left, this);
            }

        }

        private void Insert(T value, BinaryTree<T> currentNode, BinaryTree<T> parent)
        {
            if (currentNode == null || currentNode.Value.CompareTo(value) == 0)
            {
                currentNode = new BinaryTree<T>();
                currentNode.Parent = parent;
                currentNode.Value = value;
            }
            if (currentNode.Value.CompareTo(value) == 1)
                Insert(value, currentNode.Right, currentNode);
            
            else if (currentNode.Value.CompareTo(value) == -1)
                Insert(value, currentNode.Left, currentNode);
        }
    }
}


