using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Node<T>
    {
        Node<T> next = null;
        T data;

        public Node(T d) { data = d; }

        public void Add_Tail(T d)
        {
            Node<T> end =  new Node<T>(d);
            Node<T> n = this;

            while(n.next != null) n = n.next;
            n.next = end;
        }

        public void Display()
        {
            Node<T> n = this;
            while(n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
        }
    }
}
