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
        static void Main(string[] args)
        {
            Node_Ex();
            Console.ReadKey();
        }
    }
}
