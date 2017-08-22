using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Stack<T>
    {
        Node<T> top;

        public T pop()
        {
            if(top != null)
            {
                T item = top.Data;
                top = top.Next;
                return item;
            }
            return default(T);
        }

        public void push(T item)
        {
            Node<T> node = new Node<T>(item);
            node.Next = top;
            top = node;
        }
    }

    class Queue<T>
    {
        Node<T> first,last;


        public void Enqueue(T item)
        {
            if(first == null)
            {
                last = new Node<T>(item);
                first = last;
            }
            else
            {
                last.Next = new Node<T>(item);
                last = last.Next;
            }

        }

        public T Dequeue()
        {
            if(first != null)
            {
                T item = first.Data;
                first = first.Next;
                return item;
            }
            return default(T);
        }
    }
}
