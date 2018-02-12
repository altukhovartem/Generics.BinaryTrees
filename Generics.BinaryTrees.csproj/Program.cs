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
        x.Add(8);
        x.Add(6);
        x.Add(7);

        foreach (var item in x)
        {
            System.Console.WriteLine(item);
        }






        //new AutoRun().Execute(args);


    }

    public static int GoAroundTheTree(BinaryTree<int> myTree)
    {
        if(myTree.Left.SuperHasValue == true)
        {
            GoAroundTheTree(myTree.Left);
        }

        if (myTree.Right.SuperHasValue == true)
        {
            GoAroundTheTree(myTree.Right);
        }

        System.Console.WriteLine(myTree.Value);
        return myTree.Value;
    }

}
