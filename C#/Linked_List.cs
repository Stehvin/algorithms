using System;

namespace Sort
{
    // Nodes contain a value and a reference to the next node.
    class Node
    {
        public int value;
        public Node next;

        public Node(int inputVal)
        {
            value = inputVal;
        }
    }

    // Linked list objects contain nodes with references to each other.
    class LinkedList
    {
        public Node head;

        // Add a new node as the last element of the list
        public void addLast(int val)
        {
            // Check for empty list
            if (head == null)
            {
                head = new Node(val);
            }

            // Find the last node and make it point to the new node
            else
            {
                Node cur = head;
                while (cur.next != null)
                {
                    cur = cur.next;
                }

                cur.next = new Node(val);
            }
        }

        // Add a new node as the first element in the list
        public void addFirst(int val)
        {
            // Check for empty list
            if (head == null)
            {
                head = new Node(val);
            }

            // Make a new node and have it point to the head of the list.
            else
            {
                Node cur = head;
                head = new Node(val);
                head.next = cur;
            }
        }

        // Delete the last node in the list.
        public void delLast()
        {
            if (head.next != null)
            {
                // Find the last node and set it to null
                Node cur = head;
                Node temp = cur;
                while (cur.next != null)
                {
                    temp = cur;
                    cur = cur.next;
                }
                temp.next = null;
            }
            else
            {
                head = null;
            }
        }

        // Delete first node in the list.
        public void delFirst()
        {
            if (head != null)
            {
                Node cur = head.next;
                head = cur;
            }
        }

        // Print a linked list.
        public void printLL()
        {
            // Check for empty list
            if (head == null)
            {
                Console.WriteLine("LL()");
            }

            // Print each element in the list
            else
            {
                Node cur = head;
                Console.Write("LL({0}", cur.value);

                while (cur.next != null)
                {
                    cur = cur.next;
                    Console.Write(", {0}", cur.value);
                }
                Console.Write(")\n");
            }
        }

    }

    class Program
    {
        static int Main()
        {
            // Initialize linked list and test insert functions
            LinkedList List1 = new LinkedList();
            List1.addFirst(4);
            List1.addLast(6);
            List1.addFirst(9);
            List1.addLast(12);
            List1.printLL();

            // Test delete functions
            List1.delFirst();
            List1.printLL();
            List1.delLast();
            List1.printLL();
            List1.delLast();
            List1.delLast();
            List1.printLL();
            return 0;
        }
    }
}