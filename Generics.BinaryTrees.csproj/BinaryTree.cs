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

        private BinaryTree<T> right { get; set; }

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
            if (currentNode.DoesNotHaveValue)
            {
                currentNode.Value = value;
                currentNode.DoesNotHaveValue = false;
                return;
            }

            int comparisonValue = value.CompareTo(currentNode.Value);
            if (comparisonValue == 1)
            {
                //if (currentNode.Right == null)
                //    currentNode.Right= new BinaryTree<T>();
                Insert(value, currentNode.Right);
            }
            else if (comparisonValue == -1)
            {
                //if (currentNode.Left == null)
                //    currentNode.Left = new BinaryTree<T>();
                Insert(value, currentNode.Left);
            }
            
        }
    }
}


