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
        x.Add(5);
        x.Add(15);
        System.Console.WriteLine(x.Value);
        System.Console.WriteLine(x.Right.Value);
        System.Console.WriteLine(x.Left.Value);
            
        new AutoRun().Execute(args);


    }
}
