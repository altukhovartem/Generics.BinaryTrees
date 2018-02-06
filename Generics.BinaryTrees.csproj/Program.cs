using System.Collections.Generic;
using System.Linq;
using Generics.BinaryTrees;
using NUnitLite;

class Program
{
	static void Main(string[] args)
	{
        BinaryTree<int> x = new BinaryTree<int>();
        x.Add(10);
        x.Add(15);
        x.Add(25);
        x.Add(7);
        x.Add(6);

        foreach (BinaryTree<int> item in x)
        {
            System.Console.WriteLine(item.Value);
        }

        //BinaryTree<int> tree = BinaryTree.Create(new[] { 100,  });
        
            
        new AutoRun().Execute(args);


    }
}
