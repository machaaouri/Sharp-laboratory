using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Node<T>
    {
        public Node<T> Next {get; set;}
        public T Data { get; set; }

        public Node(T d) {

            Next = null;
            Data = d;
        }

        public override bool Equals(object obj)
        {
            var comparer = Comparer<T>.Default;
            T value = (T)obj;
            return comparer.Compare(Data, value) == 0;
        }

        public void addNodeToTail(T d)
        {
            Node<T> end =  new Node<T>(d);
            Node<T> n = this;

            while (n.Next != null) n = n.Next;
            n.Next = end;
        }

        public Node<T> deteleNode(Node<T> head, T d)
        {
            Node<T> n = head;

            if(n.Data.Equals(d))
            {
                return head.Next; // removed head
            }

            while (n.Next != null)
            {
                if (n.Next.Equals(d))
                {
                    n.Next = n.Next.Next;
                    break;
                }
                n = n.Next;
            }
            return head;
        }

        public void deleteDups(Node<T> node)
        {
            HashSet<T> set = new HashSet<T>();
            Node<T> prev = null;

            while (node.Next != null)
            {
                if (set.Contains(node.Data)) prev.Next = node.Next;
                else
                {
                    set.Add(node.Data);
                    prev = node;
                }

                node = node.Next;
            }
        }

        public void Display()
        {
            Node<T> n = this;
            while(n != null)
            {
                Console.WriteLine(n.Data);
                n = n.Next;
            }
        }
    }
}
