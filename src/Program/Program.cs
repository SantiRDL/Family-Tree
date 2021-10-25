using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1,"a");
            Node n2 = new Node(2,"b");
            Node n3 = new Node(3,"c");
            Node n4 = new Node(4,"d");
            Node n5 = new Node(5,"e");
            Node n6 = new Node(6,"f");
            Node n7 = new Node(7,"g");
            Node n8 = new Node(8,"h");

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);

            // visitar el árbol aquí
            
        }
    }
}
