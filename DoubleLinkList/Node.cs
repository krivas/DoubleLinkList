using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkList
{
    public class Node<T>
    {
        public Node<T> Previous { get; set; }

        public Node<T> Next { get; set; }

        public T Data { get; set; }

        public Node(T _data)
        {
            Data = _data;
        }
    }
}
