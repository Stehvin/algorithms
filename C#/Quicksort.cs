using System;

namespace Sort
{
	class Program
	{
		static int Main()
		{
            // initialize unsorted array
            int[] arr = { 54, 6, 23, 5, 7, 4, 23, 7, 85, 34};

            // print array, sort, then print sorted array
            printArr(arr);
            quicksort(arr, 0, arr.Length - 1);
            printArr(arr);
			return 0;
		}

        // sorts an array using a quicksort algorithm
        static void quicksort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // partition full array, then partition left and right sides
                int wall = partition(arr, low, high);
                quicksort(arr, low, wall - 1);
                quicksort(arr, wall + 1, high);
            }
        }

        // Paritions an array into small and large numbers,
        // based on a pivot value. Returns the final index of the pivot.
        static int partition(int[] arr, int low, int high)
        {
            // initialize pivot value, array length, wall starting index,
            // and temporary swapping variable
            int pivVal = arr[high];
            int n = arr.Length;
            int wall = -1;
            int temp;

            // iterate over all array elements (including pivot)
            for (int i = 0; i < n; i++)
            {
                // for values smaller than pivot, increment the wall index,
                // then swap the values at the current index and wall index
                if (arr[i] <= pivVal)
                {
                    wall++;
                    temp = arr[i];
                    arr[i] = arr[wall];
                    arr[wall] = temp;
                }
            }
            return wall;
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