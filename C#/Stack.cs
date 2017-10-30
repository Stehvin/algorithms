using System;

namespace Structure
{
    class Node
    {
        public int value;
        public Node next;

        public Node(int val)
        {
            value = val;
        }
    }

    class Stack
    {
        public Node head;

        public void push(int val)
        {
            if (head == null)
            {
                head = new Node(val);
            }
            else
            {
                Node prvHead = head;
                head = new Node(val);
                head.next = prvHead;
            }
        }

        public int pop()
        {
            if (head != null)
            {
                int returnVal = head.value;
                head = head.next;
                return returnVal;
            }
            return -1;
        }

        public void prtStack()
        {
            if (head == null)
            {
                Console.WriteLine("Stack()");
            }
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