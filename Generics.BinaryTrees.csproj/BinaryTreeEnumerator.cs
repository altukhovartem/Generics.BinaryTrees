using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.BinaryTrees
{
     class BinaryTreeEnumerator<T> : IEnumerator<T> 
        where T : IComparable<T>
    {
        private BinaryTree<T> OriginalTree { get; set; }
        private BinaryTree<T> CurrentNode { get; set; }
        object IEnumerator.Current => Current;
		public T Current => CurrentNode.Value;

		public BinaryTreeEnumerator(BinaryTree<T> node)
        {
            if (node == null)
                throw new Exception();
            this.OriginalTree = node;
			this.CurrentNode = new BinaryTree<T>();
        }

        public bool MoveNext()
        {
			// For the first entry, find the lowest valued node in the tree
			if (!CurrentNode.HasValue)
				CurrentNode = FindMostLeft(OriginalTree);
			else
			{
				// Can we go right-left?
				if (CurrentNode.Right.HasValue)
					CurrentNode = FindMostLeft(CurrentNode.Right);
				else
				{
					// Note the value we have found
					T CurrentValue = CurrentNode.Value;

					// Go up the tree until we find a value larger than the largest we have
					// already found (or if we reach the root of the tree)
					while (CurrentNode.HasValue)
					{
						CurrentNode = CurrentNode.Parent;
						if (CurrentNode != null)
						{
							int Compare = Current.CompareTo(CurrentValue);
							if (Compare < 0) continue;
						}
						break;
					}
				}
			}
			return (CurrentNode != null);
		}

        public void Reset()
        {
            CurrentNode = new BinaryTree<T>();
		}

        public void Dispose()
        {

		}

			BinaryTree<T> FindMostLeft(BinaryTree<T> start)
			{
				BinaryTree<T> node = start;
				while (true)
				{
					if (node.Left.HasValue)
					{
						node = node.Left;
					continue;
					}
					break;
			}
			return node;
		}
	}
}
