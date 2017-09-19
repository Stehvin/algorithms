# -*- coding: utf-8 -*-
"""
Created on Mon Sep 18 19:14:59 2017

@author: Stehvin
"""

def selectionSort(arr):
    """Sorts an "array" (list), by finding the minimum value in the
    unsorted portion of the list and moving it to the start of the
    unsorted portion.
    """
    # loop to build sorted portion
    for i in range(len(arr)):
        
        # find minimum value in unsorted portion
        minIndex = i
        for j in range(i, len(arr)):
            if arr[j] < arr[minIndex]:
                minIndex = j
        
        # swap chosen value with value at the front of the unsorted list
        minVal = arr[minIndex]        
        arr[minIndex] = arr[i]
        arr[i] = minVal
    return arr