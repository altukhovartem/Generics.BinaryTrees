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
        bool GoToRight = false;

        public BinaryTreeEnumerator(BinaryTree<T> node)
        {
            if (node == null)
                throw new Exception();
            this.Node = node;
        }

        public bool MoveNext()
        {
			GoAroundTheTree(Node);
			return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Dispose();
        }

		private static T GoAroundTheTree(BinaryTree<T> myTree)
		{
			if (myTree.Left.HasValue == true)
			{
				GoAroundTheTree(myTree.Left);
			}

			if (myTree.Right.HasValue == true)
			{
				GoAroundTheTree(myTree.Right);
			}

			System.Console.WriteLine(myTree.Value);
			return myTree.Value;
		}
	}
}
