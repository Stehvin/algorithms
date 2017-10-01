#include <stdio.h>  

void printArr(int *arr, int n);
void insertionSort(int *arr, int n);

int main()  
{  
	// initialize array and length of array
	int arr[] = {43, 2, 56, 45, 3, 3, 67, 32, 2, 68};
	int n = sizeof(arr) / sizeof(int);

	printArr(arr, n);
	insertionSort(arr, n);
	printArr(arr, n);
    return 0;  
}

void insertionSort(int *arr, int n)
{
	int i, j, cur;

	// place each element of array
	for (i = 1; i < n; i++)
	{
		// value of current element
		cur = arr[i];

		// move elements bigger than cur up one position,
		// and place cur just after the first element it is greater than
		for (j = i - 1; j >= 0; j--)
		{
			if (arr[j] > cur)
			{
				arr[j + 1] = arr[j];
			}
			else
			{
				break;
			}
		}
		arr[j + 1] = cur;
	}
}

void printArr(int *arr, int n)
{
	for (int i = 0; i < n; i++)
	{
		printf("%d ", arr[i]);
	}
	printf("\n");
}