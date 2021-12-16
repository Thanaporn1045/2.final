using System;


namespace final1
{
    class Node
    {
        public string SkillName;
        public Node right;
        public Node left;
        public Node Naxt;
        public Node(string Input)
        { 
            SkillName = Input;
            right = null;
            left = null;
            Naxt = null;
        }
    }
    class Stack
    {
        private Node root;
        public Stack()
        {
            root = null;
        }

        public void Push(Node node)
        {
            if (isrootnull()) { root = node; }
            else
            {
                node.Naxt = root;
                root = node;
            }
        }
        public Node Pop()
        {
            
            Node node = root; 
            root = root.Naxt;
            
            node.Naxt = null;
            return node;
        }
        public bool isrootnull()
        { return root is null; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node root = null; Stack stack = new Stack(); int skillup = 0;
            InputSkillName(ref root,ref stack);
        }
        static void InputSkillName(ref Node node, ref Stack stack)
        {
            char ans; 
            Console.Write("Input skill name: ");
            string skillname = Console.ReadLine();
            node = new Node(skillname);
            stack.Push(node);
            
            if(skillname == "?")
            {

            }
            else 
            { 
                Console.Write("Add dependency for {0} ? (Y/N): ", skillname);
                ans = char.Parse(Console.ReadLine());
                if(ans=='Y')
                {
                    InputSkillName(ref node.left,ref stack);

                }
                else 
                {
                    
                    stack.Pop();
                    while(true)
                    {
                        
                        Node nodecheck = stack.Pop(); if(nodecheck == null) {  break; }
                        Console.Write("Add dependency for {0} ? (Y/N): ", nodecheck.SkillName);
                        ans = char.Parse(Console.ReadLine()); 
                        if(ans == 'Y') { InputSkillName(ref node.right, ref stack); break; }
                    } 
                    InputSkillName(ref node, ref stack);

                }
            }
        }
        
    }
}
