# -*- coding: utf-8 -*-
"""
Created on Wed Sep 20 19:27:28 2017

@author: Stehvin
"""

def mergeSort(arr, low, high):
    """Sorts an "array" (list) by breaking it apart into single elements,
    then merging those elements (in ascending order) into progressively
    larger arrays.
    """
    mid = (low + high)//2
    mergeSort(arr, low, mid)
    mergeSort(arr, mid + 1, high)
    merge(arr[low:mid], arr[mid + 1:high])

def merge(arrA, arrB):
    """Merges two sorted arrays in ascending order. The length of 
    the first array must be greater than or equal to the length of 
    the second.
    """
    iA = 0
    iB = 0
    arrSorted = []
    while True:
        if iA == len(arrA):
            arrSorted += arrB[iB:]
            break
        elif iB == len(arrB):
            arrSorted += arrA[iA:]
            break
        elif arrA[iA] <= arrB[iB]:
            arrSorted.append(arrA[iA])
            iA += 1
        else:
            arrSorted.append(arrB[iB])
            iB += 1
    return arrSorted

hey = [324, 23, 234, 2, 65, 8,4, 12, 53]
mergeSort(hey)
            