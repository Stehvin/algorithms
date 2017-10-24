#include <stdio.h>

typedef struct Node
{
	int value;
	struct Node* next;
} Node;

void push(Node** top, int val)
{
	// Create new node
	Node* newTop = malloc(sizeof(Node));

	// Set new node's value and link to previous top node
	newTop->value = val;
	newTop->next = *top;
	*top = newTop;
}

int pop(Node* top)
{

}

int main()
{
	return 0;
}