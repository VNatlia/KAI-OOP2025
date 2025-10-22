using System;
using System.Collections;
using System.Collections.Generic;
using Lab3._2;

class Program
{
    static void Main()
    {
       Console.OutputEncoding = System.Text.Encoding.UTF8;

        Vector[] array = {
            new Vector("Red", 3, 4),
            new Vector("Blue", 1, 2),
            new Vector("Green", 0, 5)
        };

        Console.WriteLine("Масив ");
        foreach (var v in array) v.PrintInfo();

        // List<T>
        List<Vector> list = new List<Vector>(array);
        list.Add(new Vector("Yellow", 2, 6));
        list[0].Increase(1, 1); 
        list.RemoveAt(1);        
        Console.WriteLine("\nList<T>");
        foreach (var v in list) v.PrintInfo();

        // ArrayList 
        ArrayList arrayList = new ArrayList();
        arrayList.Add(new Vector("Orange", 2, 3));
        arrayList.Add(new Vector("Purple", 5, 5));
        Console.WriteLine("\nArrayList");
        foreach (Vector v in arrayList) v.PrintInfo();

        BinaryNode.Run();
    }
}
