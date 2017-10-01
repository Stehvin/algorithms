#include <stdio.h>

// declare functions implemented after main
int binarySearch(int *arr, int n, int value);

int main()
{
	// initialize sorted array and get its length
	int arr[] = { 3, 5, 9, 12, 24, 34, 36, 74 };
	int n = sizeof(arr) / sizeof(int);
	
	// search array for value
	int value = 23;
	int index = binarySearch(arr, n, value);
	printf("%d\n", index);
	return 0;
}

// search a sorted array using the binary search algorithm
int binarySearch(int *arr, int n, int value)
{
	// get starting high, low, and middle indicies
	int low = 0;
	int high = n - 1;
	int mid = high / 2;

	// loop until value is found or all possibilities have been exhausted
	while (low <= high)
	{
		// check if value is bigger or smaller than the middle index
		if (value > arr[mid])
			low = mid + 1;
		else if (value < arr[mid])
			high = mid - 1;
		else
			return mid;

		// recalculate middle index
		mid = (high + low) / 2;
	}

	// if the value was not found, return -1
	return -1;
}