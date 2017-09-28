#include <stdio.h>  

void printArr(int *arr);

int main()  
{  
	int arr[10] = {43, 2, 56, 45, 3, 3, 67, 32, 2, 68};
	printArr(&arr);
    return 0;  
}

void printArr(int *arr)
{
	for (int i = 0; i < 10; i++)
	{
		printf("%d ", arr[i]);
	}
	printf("\n");
}