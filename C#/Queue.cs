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
            // Check for empty queue
            if (head == null)
            {
                head = new Node(val);
            }

            // Find last node and make it reference the new node
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
            // Throw an exception if the queue is empty
            if (head == null)
            {
                throw new InvalidOperationException("Empty queue");
            }

            // Return the head node's value, and make the node in the
            // second position the new head node.
            int val = head.value;
            head = head.next;
            return val;
        }

        // Print a queue in a readable format.
        public void print()
        {
            // Check for empty queue
            if (head == null)
            {
                Console.WriteLine("Q()");
            }

            // Print each node's value
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
            Queue q = new Queue();
            q.head = new Node(8);
            q.print();
            q.enqueue(3);
            q.enqueue(2);
            q.print();

            // Test dequeue function
            int a = q.dequeue();
            q.print();
            int b = q.dequeue();
            q.print();
            int c = q.dequeue();
            q.print();
			return 0;
		}
	}
}