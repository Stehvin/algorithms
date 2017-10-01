#include <stdio.h>

// declare functions implemented after main
void printArr(int *arr, int n);
void selectionSort(int *arr, int n);

int main()
{
	// initialize array and set length
	int arr[] = { 34, 34, 23, 63, 75, 3, 64, 1, 4 };
	int n = sizeof(arr) / sizeof(int);

	// print initial array, sort array, then print sorted array
	printArr(arr, n);
	selectionSort(arr, n);
	printArr(arr, n);
	return 0;
}

// sort array using selection sort algorithm
void selectionSort(int *arr, int n)
{
	int i, j, minIndex, temp;

	// loop through array n times, sorting one element each loop
	for (i = 0; i < n; i++)
	{
		
		// find minimum element of unsorted array
		minIndex = i;
		for (j = i + 1; j < n; j++)
		{
			if (arr[j] < arr[minIndex])
				minIndex = j;
		}

		// switch minimum element and current element
		temp = arr[minIndex];
		arr[minIndex] = arr[i];
		arr[i] = temp;
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