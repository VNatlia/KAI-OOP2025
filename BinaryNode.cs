using System;

namespace Lab3._2;

public class BinaryNode
{
    public static void Run()
    {
        BinaryTree<Vector> tree = new BinaryTree<Vector>();
        tree.Insert(new Vector("Red", 3, 4));   // довжина 5
        tree.Insert(new Vector("Blue", 1, 1));  // довжина 1.41
        tree.Insert(new Vector("Green", 0, 5)); // довжина 5
        tree.Insert(new Vector("Yellow", 5, 12)); // довжина 13

        tree.Display();

        Console.WriteLine("\nВикористання ітератора");
        foreach (var v in tree)
            Console.WriteLine(v);
    }
}
