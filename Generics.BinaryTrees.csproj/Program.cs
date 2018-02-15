using System.Collections.Generic;
using System.Linq;
using Generics.BinaryTrees;
using NUnitLite;

class Program
{
	static void Main(string[] args)
	{
        BinaryTree<int> x = new BinaryTree<int>();
        x.Add(100);
        x.Add(50);
        x.Add(25);
        x.Add(30);
        x.Add(27);
        x.Add(35);
        x.Add(150);
        x.Add(125);
        x.Add(175);

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
