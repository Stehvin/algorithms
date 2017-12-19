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
	return new;
}

// Print the tree
void printTree(Node* root)
{
	// Initialize child node checking variables
	int lCheck = 0;
	int rCheck = 0;

	// Check left and right nodes
	for (int i = 0; i < 2; i++)
	{
		// Print left node's value, and the current node's value in brackets
		if (i == 0 && root->left != NULL)
		{
			printf("%d [%d] ", root->left->value, root->value);
			lCheck = 1;
		}

		// Print right node's value, and the current node's value in brackets
		else if (i == 1 && root->right != NULL)
		{
			printf("%d [%d]  \n", root->right->value, root->value);
			rCheck = 1;
		}
	}

	// Recursively print all child nodes from left and right nodes
	if (lCheck == 1)
	{
		printTree(root->left);
	}
	if (rCheck == 1)
	{
		printTree(root->right);
	}
}

// Test the implementation.
int main()
{
	// Initialize tree
	Node* root = malloc(sizeof(Node));
	root->value = 10;

	// Add nodes to root
	root->left = newNode(9);
	root->right = newNode(8);

	// Add leaves to second-level nodes
	root->right->left = newNode(7);
	root->right->right = newNode(6);
	root->left->left = newNode(5);

	// Print the tree
	printTree(root);
	return 0;
}