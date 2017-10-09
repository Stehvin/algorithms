using System;

namespace Sort
{
	class Program
	{
		static int Main()
		{
            // initialize array
            int[] arr = { 4, 234, 6, 35, 2, 45, 63, 543, 32 };

            // print original array, sort array, then print sorted array
            printArr(arr);
            selectionSort(arr);
            printArr(arr);
			return 0;
		}

        // sorts an array using a selection sort algorithm
        static void selectionSort(int[] arr)
        {
            // get length of array and initialize variables
            int n = arr.Length;
            int low;
            int temp;

            // loop over array n times, sorting one element each iteration
            for (int i = 0; i < n; i++)
            {
                low = i;

                // find smallest value in unsorted array
                for (int j = i; j < n; j++)
                {
                    if (arr[j] < arr[low])
                        low = j;
                }

                // swap smallest value with first value in unsorted array
                temp = arr[i];
                arr[i] = arr[low];
                arr[low] = temp;
            }

        }

        // prints an array on one line
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