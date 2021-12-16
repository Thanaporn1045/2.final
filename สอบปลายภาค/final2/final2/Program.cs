using System;

namespace final2
{
    class Node
    {
        public char Parts;
        public Node Naxt;
        public Node(char parts)
        {
            Parts = parts;
        }
    }
    class Queue
    {
        private Node root;
        public void Push(Node node)
        {
            if (root == null) { root = node; }
            else
            {
                Node ptr = root;
                while (ptr.Naxt != null)
                {
                    ptr = ptr.Naxt;
                }
                ptr.Naxt = node;
            }
        }
        public Node Pop()
        {
            if (root == null) { return null; }
            Node node = root;
            root = root.Naxt;
            node.Naxt = null;
            return node;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue assemblylinequeue = new Queue(); Node node; int ProductCount = 0;
            int numproduct = int.Parse(Console.ReadLine());
            while (true)
            { 
                char parts = char.Parse(Console.ReadLine());
                node = new Node(parts);
                assemblylinequeue.Push(node);
                if (parts == 'E') { ProductCount++; break; }
                else
                {

                }
            } 
        }
    }
}
