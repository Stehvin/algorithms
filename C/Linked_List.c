#include <stdio.h>

// Define a 'Node' struct, which includes an integer value and a pointer
// to the next node.
typedef struct Node
{
	int value;
	struct Node *next;
} Node;

// Insert a new node into the linked list defined by the 'head' pointer.
void insert(Node *head, int val)
{
	Node *cur = head;
	
	// Find the last node in the linked list
	while (cur->next != NULL)
	{
		cur = cur->next;
	}

	// Create new node at the end of the linked list
	cur->next = malloc(sizeof(Node));
	cur->next->next = NULL;
	cur->next->value = val;
}

// Print a linked list in a readable format.
void printLL(Node *head)
{
	Node *cur = head;
	
	// Check if list is empty
	if (cur == NULL)
		printf("LL()\n");
	else
		printf("LL(%d", cur->value);

	// Print each node's value until the end of the list is reached.
	while (cur->next != NULL)
	{
		printf(", %d", cur->next->value);
		cur = cur->next;
	}

	// End of linked list
	printf(")\n");
}

int main()
{
	// Initialize linked list head node
	Node *head = malloc(sizeof(Node));
	head->next = NULL;
	head->value = 34;
	printLL(head);

	// Add test items to linked list
	insert(head, 2);
	insert(head, 5);
	insert(head, 66);
	printLL(head);
	return 0;
}

