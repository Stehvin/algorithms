using System;

namespace Sort
{
	class Program
	{
		static int Main()
		{
            // initialize array
            int[] arr = { 34, 25, 345, 34, 7, 867, 45, 4, 12 };

            // print original array, sort array, then print sorted array
            printArr(arr);
            insertionSort(arr);
            printArr(arr);
            return 0;
		}

        // sorts an array using an insertion sort algorithm
        static void insertionSort(int[] arr)
        {
            // get array length and initialize variables
            int n = arr.Length;
            int cur;
            int j;

            // loop over each element in array
            for (int i = 0; i < n; i++)
            {
                // store the value of the current element
                cur = arr[i];
                
                // move elements greater than cur up one position, and
                // place cur after the first element it is greater than
                for (j = i - 1; j > -1; j--)
                {
                    if (arr[j] > cur)
                        arr[j + 1] = arr[j];
                    else
                        break;
                }
                arr[j + 1] = cur;
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