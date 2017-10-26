#include <stdio.h>

// Node struct contains an integer value and a pointer to the next Node.
typedef struct Node
{
	int value;
	struct Node* next;
} Node;

// Add new node to the end of the queue.
void enqueue(Node* head, int val)
{
	Node* cur = head;

	// Find the last node in the queue
	while (cur->next != NULL)
	{
		cur = cur->next;
	}

	// Add new node in last queue position
	cur->next = malloc(sizeof(Node));
	cur->next->value = val;
	cur->next->next = NULL;
}

// Remove the first node in the queue and return its value.
int dequeue(Node** head)
{
	// Check for empty queue
	if (*head == NULL)
	{
		return NULL;
	}
	
	// Save head node's parameters, then delete it.
	int val = (*head)->value;
	Node* newHead = (*head)->next;
	free(*head);

	// Re-assign head node pointer and return saved value.
	*head = newHead;
	return val;
}

// Print a queue in a readable format.
void printQ(Node* head)
{
	// Beginning print statement
	printf("Q(");

	// Ensure queue is not empty
	if (head != NULL)
	{
		// Print the first node in queue
		Node* cur = head;
		printf("%d", cur->value);

		// Print all subsequent nodes in queue
		while (cur->next != NULL)
		{
			cur = cur->next;
			printf(", %d", cur->value);
		}
	}

	// Ending print statement
	printf(")\n");
}

int main()
{
	// Initialize queue and test enqueue function.
	printQ(NULL);
	Node* head = malloc(sizeof(Node));
	head->value = 71;
	head->next = NULL;
	printQ(head);
	enqueue(head, 50);
	enqueue(head, 39);
	printQ(head);

	// Test dequeue function
	int a = dequeue(&head);
	int b = dequeue(&head);
	printQ(head);
	return 0;
}