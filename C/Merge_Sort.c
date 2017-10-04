#include <stdio.h>

// declare functions implemented after main
void printArr(int *arr, int n);
void mergeSort(int *arr, int left, int right);
void merge(int *arr, int left, int mid, int right);

int main()
{
	// initialize array and get length
	int arr[] = { 54, 45, 75, 1, 324, 3, 2, 4, 33, 2 };
	int n = sizeof(arr) / sizeof(int);

	// print initial array, sort array, then print sorted array
	printArr(arr, n);
	mergeSort(arr, 0, n - 1);
	printArr(arr, n);
	return 0;
}

// sort array using the merge sort algorithm
void mergeSort(int *arr, int left, int right)
{
	int mid;

	// sort left subarray and right subarray, then merge the two
	if (left < right)
	{
		mid = (left + right) / 2;
		mergeSort(arr, left, mid);
		mergeSort(arr, mid + 1, right);
		merge(arr, left, mid, right);
	}
}

// merge two sorted arrays
void merge(int *arr, int left, int mid, int right)
{
	// get length of each subarray
	int nLeft = mid - left + 1;
	int nRight = right - mid;
	
	// create each subarray
	int *leftArr = (int *)malloc(sizeof(int) * nLeft);
	int *rightArr = (int *)malloc(sizeof(int) * nRight);
	for (int i = 0; i < nLeft; i++)
		leftArr[i] = arr[left + i];
	for (int i = 0; i < nRight; i++)
		rightArr[i] = arr[mid + 1 + i];

	// initialize variables to track each subarray's index
	int iLeft = 0;
	int iRight = 0;
	int iArr = left;

	while (1)
	{
		// if either subarray is empty, place all remaining elements of
		// the other subarray into arr
		if (iLeft == nLeft)
		{
			for (int i = 0; i < nRight - iRight; i++)
			{
				arr[iArr + i] = rightArr[iRight + i];
			}
			break;
		}
		else if (iRight == nRight)
		{
			for (int i = 0; i < nLeft - iLeft; i++)
			{
				arr[iArr + i] = leftArr[iLeft + i];
			}
			break;
		}
		
		// compare first element of each subarray, place smaller element in arr
		if (leftArr[iLeft] < rightArr[iRight])
		{
			arr[iArr] = leftArr[iLeft];
			iLeft++;
		}
		else
		{
			arr[iArr] = rightArr[iRight];
			iRight++;
		}

		// increment arr index
		iArr++;
	}

	// free malloc'd space for two subarrays
	free(leftArr);
	free(rightArr);
}

// prints an array
void printArr(int *arr, int n)
{
	for (int i = 0; i < n; i++)
	{
		printf("%d ", arr[i]);
	}
	printf("\n");
}