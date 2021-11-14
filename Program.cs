using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            List Cpu1 = new List();
            List Cpu2 = new List();
            List Cpu3 = new List();
            List Cpu4 = new List();

            string input = "";
            while (input != "?")
            {
                input = (Console.ReadLine());          // inputข้อมูลโดยไม่เว้นวรรค
                if(input != "?")
                {
                    char[] charArray = input.ToCharArray();
                    Node maiandata = new Node(charArray[0], charArray[1]);
                    queue.Push(maiandata);
                    
                }
            }
            //Console.WriteLine(queue.Pop());
            //Console.WriteLine(queue.Pop());
            //Console.WriteLine(queue.Pop());
        }
    }

    class Node
    {
        public char instruction;
        public char data;

        public Node Next;

        public Node (char instructionValue, char dataValue)
        {
            instruction = instructionValue;
            data = dataValue;
            Next = null;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", instruction, data);
        }
    }

    class Queue
    {
        public Node root = null;

        public void Push(Node node)
        {
            if(root == null)
            {
                root = node;
            }
            else
            {
                Node ptr = root;
                while (ptr.Next != null)
                {
                    ptr = ptr.Next;
                }
                ptr.Next = node;
            }
        }

        public Node Pop()
        {
            Node node;
            if (root == null)
            {
                return null;
            }
            node = root;
            root = root.Next;
            node.Next = null;
            return node;
        }

        
    }

    class List
    {
        public Node Headptr;
        public void AddNode(Node node)
        {
            if (Headptr == null)
            {
                Headptr = node;
            }
            else
            {
                Node Tailptr = Headptr;
                while (Tailptr.Next != null)
                {
                    Tailptr = Tailptr.Next;
                }
                Tailptr.Next = node;
            }
        }
    }
}
