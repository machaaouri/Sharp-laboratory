using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        static void Stack_Ex_min()
        {
            StackWithMin<int> stack = new StackWithMin<int>();
            stack.push(2);
            stack.push(11);
            stack.push(12);
            stack.push(9);
            stack.push(1);
            Console.WriteLine(stack.pop());
            stack.getMin();

        }
        static void Main(string[] args)
        {
            //Node_Ex();
            //Stack_Ex();
            Stack_Ex_min();
            Console.ReadKey();
        }
    }
}
