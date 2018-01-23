using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.BinaryTrees
{

    public class Node
    {
        Node Parent { get; set; }
        Node Left { get; set; }
        Node Right { get; set; }
        public int Value { get; set; }

        public Node(int value)
        {
            this.Value = value;
        }

    }

    public class BinaryTree : IEnumerable
    {
        public Node Head { get; set; }

        public int Count { get; private set; }

        public BinaryTree(int head)
        {
            Head = new Node(head);
            Count = 1;
        }

        public BinaryTree()
        {
            Head = null;
            Count = 0;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        

        public void Add(Node NewNode)
        {
            if (Count == 0)
            {
                Head = NewNode;
                Count++;
            }

            else
            {
                if (Head)
            }
                
        }
    }
}
