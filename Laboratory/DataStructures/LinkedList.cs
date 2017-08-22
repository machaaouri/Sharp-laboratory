using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            while(n.next != null) n = n.next;
            n.next = end;
        }

        public Node<T> deteleNode(Node<T> head, T d)
        {
            Node<T> n = head;

            if(n.Data.Equals(d))
            {
                return head.next; // removed head
            }

            while(n.next != null)
            {
                if(n.next.Equals(d))
                {
                    n.next = n.next.next;
                    break;
                }
                n = n.next;
            }
            return head;
        }

        public void deleteDups(Node<T> node)
        {
            HashSet<T> set = new HashSet<T>();
            Node<T> prev = null;

            while(node.next != null)
            {
                if (set.Contains(node.Data))  prev.next = node.next;
                else
                {
                    set.Add(node.Data);
                    prev = node;
                }

                node = node.next;
            }
        }

        public void Display()
        {
            Node<T> n = this;
            while(n != null)
            {
                Console.WriteLine(n.Data);
                n = n.next;
            }
        }
    }
}
