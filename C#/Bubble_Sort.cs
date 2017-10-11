using System;

namespace Sort
{
	class Program
	{
		static int Main()
		{
            // initialize array
            int[] arr = { 7, 46, 78, 23, 5, 4, 243, 53, 23 };

            // print original array, sort array, then print sorted array
            printArr(arr);
            bubbleSort(arr);
            printArr(arr);
            return 0;
		}

        // sorts an array using a bubble sort algorithm
        static void bubbleSort(int[] arr)
        {
            // get array's length and initialize variables
            int n = arr.Length;
            int temp;

            // Loop over array n - 1 times. Each iteration sorts one element,
            // except the last iteration, which sorts two.
            for (int i = 0; i < n - 1; i++)
            {
                // compare each pair of adjacent elements in array
                for (int j = 0; j < n - 1 - i; j++)
                {
                    // swap elements if left element is greater than right 
                    // element
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
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