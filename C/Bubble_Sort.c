#include <stdio.h>

// declare functions implemented after main
void bubbleSort(int *arr, int n);
void printArr(int *arr, int n);

int main()
{
	// initialize array and get length
	int arr[] = { 5, 3, 36, 24, 74, 9, 12, 75, 34 };
	int n = sizeof(arr) / sizeof(int);

	// print initial array, sort array, then print sorted array
	printArr(arr, n);
	bubbleSort(arr, n);
	printArr(arr, n);
	return 0;
}

// sorts array using the bubble sort algorithm
void bubbleSort(int *arr, int n)
{
	int i, j, temp;

	for (i = 0; i < n - 1; i++)
	{
		for (j = i; j < n - i - 1; j++)
		{
			if (arr[j] > arr[j + 1])
			{
				temp = arr[j];
				arr[j] = arr[j + 1];
				arr[j + 1] = temp;
			}
		}
	}
}

// print an array
void printArr(int *arr, int n)
{
	for (int i = 0; i < n; i++)
	{
		printf("%d ", arr[i]);
	}
	printf("\n");
}