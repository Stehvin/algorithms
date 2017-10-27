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

        public void addLast(int val)
        {
            if (head == null)
            {
                head = new Node(val);
            }
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

        public void addFirst(int val)
        {
            if (head == null)
            {
                head = new Node(val);
            }
            else
            {
                Node cur = head;
                head = new Node(val);
                head.next = cur;
            }
        }
    }

    class Program
    {
        static int Main()
        {
            return 0;
        }
    }
}