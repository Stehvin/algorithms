# -*- coding: utf-8 -*-
"""
Created on Thu Sep 21 18:00:15 2017

@author: Stehvin
"""

def quickSort(arr):
    """Sorts an "array" (list) by choosing a "pivot" number and finding
    which elements are bigger or smaller than this number. Then, both
    the smaller element array and the bigger element array repeat this
    process internally. This continues recursively until each array is
    only one element long, then they are recombined.
    """
    return recursion(arr, 0, len(arr) - 1)

def recursion(arr, low, high): 
    # base case, array is empty
    if low >= high:
        return []
    
    # recursive case, array has multiple elements
    wall = partition(arr, low, high)
    recursion(arr, low, wall - 1)
    recursion(arr, wall + 1, high)
    
def partition(arr, low, high):
    pivot = arr[high]
    wall = low - 1
    
    for i in range(low, high):
        if arr[i] <= pivot:
            wall += 1
            arr[i], arr[wall] = arr[wall], arr[i]
    
    wall += 1
    arr[high], arr[wall] = arr[wall], arr[high]
    return wall

# testing
listA = [4, 5, 23, 78, 12, 657, 12, 4, 74, 12]
quickSort(listA)
print(listA)