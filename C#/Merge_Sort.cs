using System;

namespace Sort
{
	class Program
	{
		static int Main()
		{
            // initialize array
            int[] arr = { 34, 1, 324, 6, 3, 12, 3, 254, 24};

            // print original array, sort, then print sorted array
            printArr(arr);
            mergeSort(arr, 0, arr.Length - 1);
            printArr(arr);
            return 0;
		}

        // sorts an array using a merge sort algorithm
        static void mergeSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int mid = (high + low) / 2;

                // sort left side and right side, then merge them together
                mergeSort(arr, low, mid);
                mergeSort(arr, mid + 1, high);
                merge(arr, low, mid, high);
            }
        }

        // merges two sorted subarrays, which are defined by indicies "low",
        // "mid", and "high"
        static void merge(int[] arr, int low, int mid, int high)
        {
            // create new arrays for left and right subarrays
            int[] left = new int[mid - low + 1];
            int[] right = new int[high - mid];
            Array.Copy(arr, low, left, 0, mid - low + 1);
            Array.Copy(arr, mid + 1, right, 0, high - mid);

            // initialize main, left, and right array index counting variables
            int iArr = low;
            int iL = 0;
            int iR = 0;

            // compare first elements of each array, placing the smaller
            // element into the next position in the main array
            while (iL < left.Length && iR < right.Length)
            {
                if (left[iL] <= right[iR])
                {
                    arr[iArr] = left[iL];
                    iL++;
                }
                else
                {
                    arr[iArr] = right[iR];
                    iR++;
                }
                iArr++;
            }

            // place all elements from remaining array into main array
            if (iR == right.Length)
            {
                for (int i = iL; i < left.Length; i++)
                {
                    arr[iArr] = left[i];
                    iArr++;
                }
            }
            else
            {
                for (int i = iR; i < right.Length; i++)
                {
                    arr[iArr] = right[i];
                    iArr++;
                }
            }
        }

        // prints an array
        static void printArr(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.Write("\n");
        }
	}
}