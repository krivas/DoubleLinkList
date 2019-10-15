using System;

namespace DoubleLinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new DoubleLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Print();
            
            list.DeleteByPosition(0);
            list.DeleteByPosition(6);
            list.DeleteByPosition(2);
          
            list.Print();

        }
    }
}
