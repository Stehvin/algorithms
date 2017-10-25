#include <stdio.h>

/* Define a 'Node' struct, which includes an integer value and a pointer
   to the next node. */
typedef struct Node
{
	int value;
	struct Node* next;
} Node;

// Add nodes to the top of the stack.
void push(Node** top, int val)
{
	// Create new node
	Node* newTop = malloc(sizeof(Node));

	// Set new node's value and link to previous top node
	newTop->value = val;
	newTop->next = *top;
	*top = newTop;
}

// Remove nodes from the top of the stack (and return their values).
int pop(Node** top)
{
	// Check for empty stack
	if (*top == NULL)
	{
		return NULL;
	}

	// Save top node's parameters, then delete it.
	int val = (*top)->value;
	Node* newTop = (*top)->next;
	free(*top);

	// Reassign top node pointer and return saved value.
	*top = newTop;
	return val;
}

// Prints a stack in a readable format.
void printStack(Node* top)
{
	Node* cur = top;
	
	// Check for empty stack
	if (top == NULL)
	{
		printf("Stack(");
	}

	// Print each node's value until the end of the stack is reached.
	else
	{
		printf("Stack(%d", cur->value);
		while (cur->next != NULL)
		{
			cur = cur->next;
			printf(", %d", cur->value);
		}
	}
	
	// End of stack
	printf(")\n");
}

int main()
{
	// Initialize stack and test push function
	printStack(NULL);
	Node* top = malloc(sizeof(Node));
	top->value = 3;
	top->next = NULL;
	push(&top, 21);
	push(&top, 65);
	printStack(top);

	// Test pop function
	int a = pop(&top);
	printStack(top);
	int b = pop(&top);
	printStack(top);
	int c = pop(&top);
	printStack(top);

	return 0;
}