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
            node.Add_Tail(6);
            node.Add_Tail(9);

            node.Display();
        }
        static void Main(string[] args)
        {
            Node_Ex();
            Console.ReadKey();
        }
    }
}
