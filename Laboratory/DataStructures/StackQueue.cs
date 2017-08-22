using System;

namespace DataStructures
{
    class Stack<T>
    {
        internal Node<T> top;

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

        public T peek()
        {
            T value = top.Data;
            return value;
        }

        public void Display()
        {
            while (top != null)
            {
                Console.WriteLine(top.Data);
                top = top.Next;
            }
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

    class ThreeStacksArray
    {
        static int arraySize = 300;
        int[] array =  new int[arraySize * 3];
        int[] trackTopItems = { 0, 0, 0 };

        public void push(int stackNum,int item)
        {
            int index = arraySize * stackNum + trackTopItems[stackNum] + 1 ;
            trackTopItems[stackNum]++;
            array[index] = item;
        }

        public int pop(int stackNum)
        {
            int index = arraySize * stackNum + trackTopItems[stackNum];
            trackTopItems[stackNum]--;
            int item = array[index];
            array[index] = 0;
            return item;
        }

        public int peek(int stackNum)
        {
            int index = arraySize * stackNum + trackTopItems[stackNum];
            return array[index];
        }

        public bool isEmpty(int stackNum)
        {
            return trackTopItems[stackNum] == arraySize * stackNum;
        }

    }
}
