#include <stdio.h>


typedef struct Node
{
	int value;
	struct Node *next;
} Node;

void insert(Node *head, int val)
{
	Node *cur = head;
	while (cur->next != NULL)
	{
		cur = cur->next;
	}
	cur->next = malloc(sizeof(Node));
	cur->next->next = NULL;
	cur->next->value = val;
}

void printLL(Node *head)
{
	Node *cur = head;
	if (cur == NULL)
		printf("LL()\n");
	else
		printf("LL(%d", cur->value);

	while (cur->next != NULL)
	{
		printf(", %d", cur->next->value);
		cur = cur->next;
	}
	printf(")\n");
}

int main()
{
	// initialize linked list head node
	Node *head = malloc(sizeof(Node));
	head->next = NULL;
	head->value = 34;
	printLL(head);

	// add test items to linked list
	insert(head, 2);
	insert(head, 5);
	insert(head, 66);
	printLL(head);
	return 0;
}

