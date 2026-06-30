using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSARoadMap
{
    internal class Program
    {

        //https://github.com/arun4duddu/DSARoadMap

        //Linked Lists
        public class Node
        {
            public Node next;
            public int value;

            public Node(int value)
            {
                this.value = value;
            }
        }

        public static Node Head;
        public static Node Tail;



        public static void insertNode(int value)
        {
            Node node = new Node(value);
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.next = node;
                Tail = node;
            }
        }


        //INSERT AT A HEAD
        public static void InsertAtHead(int value)
        {
            Node node = new Node(value);
            Node dummy = new Node(0);


            if (Head != null)
            {
                dummy.next = node;
                node.next = Head;
                Head = node;
            }
        }

        //insertAtTail()
        public static void insertAtTail(int value)
        {
            Node node = new Node(value);
            if (Tail != null)
            {
                Tail.next = node;
                Tail = node;
            }
        }

        //insertAtPosition(int)
        // 1->2->3->4
        // 1->2->3->5->4

        public static void insertAtPosition(int position, int value)
        {
            if (position < 1) return;

            Node newNode = new Node(value);

            // Insert at head
            if (position == 1)
            {
                newNode.next = Head;
                Head = newNode;
                if (Tail == null) Tail = newNode;
                return;
            }

            Node current = Head;
            int count = 1;

            //get to the desired node
            while (current != null && count < position - 1)
            {
                current = current.next;
                count++;
            }

            if (current == null) return;

            newNode.next = current.next;
            current.next = newNode;

            if (newNode.next == null) return;

        }

        static void Main(string[] args)
        {
            insertNode(2);
            insertNode(3);
            insertNode(4);

            InsertAtHead(1);
        }

    }
}
