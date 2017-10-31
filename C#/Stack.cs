using System;

namespace Structure
{
    // Nodes contain a value and reference to the next node.
    class Node
    {
        public int value;
        public Node next;

        public Node(int val)
        {
            value = val;
        }
    }

    // Implement a stack (FIFO) structure.
    class Stack
    {
        public Node head;

        // Insert a new node on the top of the stack.
        public void push(int val)
        {
            // Check for empty stack
            if (head == null)
            {
                head = new Node(val);
            }

            // Add new node and have it reference the old head node
            else
            {
                Node prvHead = head;
                head = new Node(val);
                head.next = prvHead;
            }
        }

        // Remove a node from the top of the stack. Return its value.
        public int pop()
        {
            if (head != null)
            {
                int returnVal = head.value;
                head = head.next;
                return returnVal;
            }

            // Throw exception if stack is empty.
            throw new InvalidOperationException("Empty Stack");
        }

        // Print the stack in a readable format.
        public void prtStack()
        {
            // Check for empty stack
            if (head == null)
            {
                Console.WriteLine("Stack()");
            }

            // Print each node of stack.
            else
            {
                Node cur = head;
                Console.Write("Stack({0}", cur.value);
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
            // Initialize stack and test push function
            Stack stk = new Stack();
            stk.push(83);
            stk.push(73);
            stk.push(8);
            stk.prtStack();

            // Test pop function
            int a = stk.pop();
            stk.prtStack();
            int b = stk.pop();
            stk.prtStack();
            int c = stk.pop();
            stk.prtStack();
            return 0;
		}
	}
}