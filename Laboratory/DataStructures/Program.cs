using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Node_Ex()
        {
            Node<int> node = new Node<int>(5);
            node.addNodeToTail(6);
            node.addNodeToTail(6);
            node.addNodeToTail(9);
            node.addNodeToTail(6);


            node.Display();
            Console.WriteLine("----");
            node.deleteDups(node);

            node.Display();

        }

        static void Stack_Ex()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.push(1);
            stack.push(11);
            stack.push(12);
            stack.push(9);
            stack.Display();

        }

        /*
         * Sort stack using another stack 
        */ 
        static Stack<int> sort(Stack<int> s)
        {
            Stack<int> r = new Stack<int>();

            while(s.Count != 0)
            {
                int tmp = s.Pop();
                while(r.Count != 0 && tmp > r.Peek())
                {
                    s.Push(r.Pop());
                }
                r.Push(tmp);
            }

            return r;
        }

        static void Sort_Ex()
        {
            Stack<int> s = new Stack<int>();
            s.Push(1); s.Push(12); s.Push(3);

            s = sort(s);

            foreach(var n in s)
            {
                Console.WriteLine(n);
            }
        }
        

        static void BalancedTree()
        {
            Tree tree = new Tree();
            tree.add(5); tree.add(52);
            tree.add(2); tree.add(15);
            tree.add(9); tree.add(1);
            tree.add(6); tree.add(3);

            TNode max = tree.findMax(tree.root);
            Console.WriteLine(max.Data);
            tree.Delete(ref tree.root, 52);
            max = tree.findMax(tree.root);
            Console.WriteLine(max.Data);

            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            tree.root = tree.CreateBST(A, 0, A.Length - 1);


        }

        static void Main(string[] args)
        {
            //Node_Ex();
            //Stack_Ex();
            //Sort_Ex();
            BalancedTree();
            Console.ReadKey();
        }
    }
}
