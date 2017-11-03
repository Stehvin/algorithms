using System;

namespace Structure
{
    // Nodes contain an integer value and a reference to the next node.
    class Node
    {
        public int value;
        public Node next;

        public Node(int val)
        {
            value = val;
        }
    }

    // In a queue, nodes are added to the tail and removed from the head.
    class Queue
    {
        public Node head;

        // Add a node to the tail of the queue.
        public void enqueue(int val)
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

        // Remove a node from the head of the queue and return its value.
        public int dequeue()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Empty queue");
            }
            int val = head.value;
            head = head.next;
            return val;
        }

        // Print a queue in a readable format.
        public void print()
        {
            if (head == null)
            {
                Console.WriteLine("Q()");
            }
            else
            {
                Node cur = head;
                Console.Write("Q({0}", cur.value);
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
            // Initialize queue and test enqueue function

            // Test dequeue function

			return 0;
		}
	}
}