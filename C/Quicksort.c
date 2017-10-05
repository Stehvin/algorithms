#include <stdio.h>

// declare functions implemented after main
void printArr(int *arr, int n);
void quickSort(int *arr, int low, int high);
int partition(int *arr, int low, int high);

int main()
{
	// initialize array and get length
	int arr[] = { 35, 63, 23, 56, 5, 2, 53, 57, 12, 4 };
	int n = sizeof(arr) / sizeof(int);

	// print array, sort array, then print sorted array
	printArr(arr, n);
	quickSort(arr, 0, n - 1);
	printArr(arr, n);
	return 0;
}

// Sorts an array using a quicksort algorithm.
void quickSort(int *arr, int low, int high)
{
	// repeat until array is empty
	if (low < high)
	{
		// partition array, then partition left and right sides
		int wall = partition(arr, low, high);
		quickSort(arr, low, wall - 1);
		quickSort(arr, wall + 1, high);
	}
}

// Puts array elements smaller than pivot on pivot's left side, and elements
// bigger than pivot on pivot's right side, then returns pivot's index.
int partition(int *arr, int low, int high)
{
	// set pivot and initialize wall, which indicates the division between
	// small and large elements
	int pivot = arr[high];
	int wall = low - 1;
	int swapTemp;

	// iterate over all array elements (including pivot)
	for (int i = low; i <= high; i++)
	{
		// place elements smaller than pivot to the left side of the
		// dividing wall
		if (arr[i] <= pivot)
		{
			wall++;
			swapTemp = arr[i];
			arr[i] = arr[wall];
			arr[wall] = swapTemp;
		}
	}
	return wall;
}

// Prints an array.
void printArr(int *arr, int n)
{
	for (int i = 0; i < n; i++)
	{
		printf("%d ", arr[i]);
	}
	printf("\n");
}