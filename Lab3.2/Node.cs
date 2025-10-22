using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab3._2
{

    public class Node<T>
    {
        public T Data;
        public Node<T> Left;
        public Node<T> Right;
        public Node(T data)
        {
           Data = data;
        }
    }

}
