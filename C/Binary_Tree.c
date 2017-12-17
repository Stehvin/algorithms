#include <stdio.h>

// Define a binary tree node. Each node can have a maximum of two child nodes.
typedef struct Node
{
	int value;
	struct Node* left;
	struct Node* right;
} Node;

// Add a new child node to the tree.
Node* newNode(int val)
{
	// Initialize new node with data provided
	Node* new = malloc(sizeof(Node));
	new->value = val;
	new->left = NULL;
	new->right = NULL;
}

// Test the implementation.
int main()
{
	return 0;
}