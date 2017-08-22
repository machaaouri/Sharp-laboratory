using System;

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
            Stack<int> stack = new Stack<int>();
            stack.push(1);
            stack.push(11);
            stack.push(12);
            stack.push(9);
            stack.Display();

        }

        static void Main(string[] args)
        {
            //Node_Ex();
            Stack_Ex();
            Console.ReadKey();
        }
    }
}
