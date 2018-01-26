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

        System.Console.WriteLine(x.Value);
        System.Console.WriteLine(x.Right.Value);
        System.Console.WriteLine(x.Right.Right.Value);
            
        new AutoRun().Execute(args);


    }
}
