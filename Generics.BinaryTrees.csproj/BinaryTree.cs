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
        private BinaryTree<T> left;

        public BinaryTree<T> Left
        {
            get {
                    if (left == null)
                    {
                        left = new BinaryTree<T>();
                    }
                    return left;
                }
            set { left = value; }
        }

        private BinaryTree<T> right;

        public BinaryTree<T> Right
        { 
            get
            {
                if (right == null)
                {
                    right = new BinaryTree<T>();
                }
                return right;
            }
            set { right = value; }
        }

        public T Value { get; set; }
        private bool HasValue = false;
     

        public IEnumerator GetEnumerator()
        {
            Stack<BinaryTree<T>> stack = new Stack<BinaryTree<T>>();
            BinaryTree<T> currentNode = this;
            bool hasLeft = true;

            stack.Push(currentNode);
            while(true)
            {
                while (hasLeft)
                {
                    if (currentNode.Left.HasValue)
                    {
                        currentNode = currentNode.Left;
                        stack.Push(currentNode);
                    }
                    else
                    {
                        hasLeft = false;
                    }
                }
                
                if (currentNode.Right.HasValue)
                {
                    currentNode = currentNode.Right;
                    stack.Push(currentNode);
                    hasLeft = true;
                }
                else
                {
                    yield return stack.Pop();
                    currentNode = stack.Peek();
                }
            }
        }


            
         
        
        
        public void Add(T value)
        {
            if (HasValue == false)
            {
                this.Value = value;
                HasValue = true;
                return;
            }
            else
            {
                if (value.CompareTo(this.Value) == 1)
                {
                    Insert(value, Right);
                }
                else if ((value.CompareTo(this.Value) == -1))
                {
                    Insert(value, Left);
                }
            }
        }

        private void Insert(T value, BinaryTree<T> currentNode)
        {
            if (currentNode.HasValue == false)
            {
                currentNode.Value = value;
                currentNode.HasValue = true;
                return;
            }

            int comparisonValue = value.CompareTo(currentNode.Value);
            if (comparisonValue == 1)
            {
                Insert(value, currentNode.Right);
            }
            else if (comparisonValue == -1)
            {
                Insert(value, currentNode.Left);
            }
            
        }
    }

    public static class BinaryTree
    {
        public static BinaryTree<int> Create(params int[] items)
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            for (int i = 0; i < items.Length; i++)
            {
                binaryTree.Add(items[i]);
            }
            return binaryTree;
        }
    }

}


