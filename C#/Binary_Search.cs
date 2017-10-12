using System;

namespace Search
{
	class Program
	{
		static int Main()
		{
            // initialize sorted array and value to search for
            int[] arr = { 2, 3, 4, 13, 24, 50, 56, 67, 70, 245};
            int val = 56;

            // search for value, output index if found, output "-1" if
            // not found
            int index = binarySearch(arr, 0, arr.Length - 1, val);
            Console.WriteLine("{0}", index);
			return 0;
		}

        // search for a value in an array using binary search
        static int binarySearch(int[] arr, int low, int high, int val)
        {
            // return -1 if value could not be found
            if (low > high)
                return -1;
            
            // calculate middle index
            int mid = (high + low) / 2;

            // If value is lower or higher than the middle element, change the
            // index boundaries and repeat the search. If value equals the
            // middle index, return the middle index.
            if (val < arr[mid])
                return binarySearch(arr, low, mid - 1, val);
            else if (val > arr[mid])
                return binarySearch(arr, mid + 1, high, val);
            else
                return mid;
        }
	}
}