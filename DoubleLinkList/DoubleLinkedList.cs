using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkList
{
    public class DoubleLinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public int Length { get; set; }

        public void Add(T data)
        {
            var node = new Node<T>(data);

            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else 
            {
                Tail.Next = node;
                node.Previous = Tail;
                Tail = node;
            }
            Length++;
        }

        public void DeleteByPosition(int position)
        {
            if (Length == position || position > Length)
                throw new IndexOutOfRangeException();
            else if (Length == 1 && position == 0)
            {
                Head = null;
                Tail = null;
                Length = Length - 1;
            }
            else if (Length > 1 && position == 0)
            {
                Head = Head.Next;
                Head.Previous= null;
                Length = Length - 1;
            }
            else if (Length == position + 1)
            {
                var node = FindNode(position);
                if (node != null)
                {
                    Tail = Tail.Previous;
                    node.Previous = null;
                    Tail.Next = null;
                    Length = Length - 1;
                }
            }
            else
            {
                var node = FindNode(position);
                if (node != null)
                {
                    node.Previous.Next = node.Next;
                    node.Next.Previous = node.Previous;
                    node.Next = null;
                    node.Previous = null;

                    Length = Length - 1;
                }

            }

        }

        private Node<T> FindNode(int position)
        {
            var current = Head;
            if (position < 0)
                throw new IndexOutOfRangeException();
            else if (position == 0)
                return current;
            else if (position >= 1 && position <= Length)
            {
                for (int i = 0; i < position; i++)
                    current = current.Next;
                return current;
            }
            else
            throw new IndexOutOfRangeException();
        } 
        public void Print()
        {
            if (Head == null) return;
            var current = Head;

            while (current!=null)
            {
                if (current == Tail)
                    Console.Write(current.Data);
                else
                    Console.Write(current.Data + ",");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void PrintReverse()
        {
            if (Tail == null) return;
            var current = Tail;
            
            while (current != null)
            {
                if (current == Head)
                    Console.Write(current.Data);
                else 
                    Console.Write(current.Data + ",");
                current = current.Previous;
            }
            Console.WriteLine();
        }


    }
}
