using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab3._2;

 public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private Node<T> root;

        public void Insert(T value)
        {
            root = InsertRec(root, value);
        }

        private Node<T> InsertRec(Node<T> node, T value)
        {
            if (node == null) return new Node<T>(value);
            if (value.CompareTo(node.Data) < 0)
                node.Left = InsertRec(node.Left, value);
            else
                node.Right = InsertRec(node.Right, value);
            return node;
        }

        //обхід
        public void Preorder(Node<T> node)
        {
            if (node == null) return;
            Console.WriteLine(node.Data);
            Preorder(node.Left);
            Preorder(node.Right);
        }

        public void Display()
        {
            Console.WriteLine("\nPreorder обхід дерева");
            Preorder(root);
        }

        // Реалізація ітератора
        public IEnumerator<T> GetEnumerator()
        {
            return PreorderEnum(root).GetEnumerator();
        }

        private IEnumerable<T> PreorderEnum(Node<T> node)
        {
            if (node != null)
            {
                yield return node.Data;
                foreach (var n in PreorderEnum(node.Left))
                    yield return n;
                foreach (var n in PreorderEnum(node.Right))
                    yield return n;
            }
        }

       IEnumerator IEnumerable.GetEnumerator()
       {
          return GetEnumerator();
       }
    }

