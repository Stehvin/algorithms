# -*- coding: utf-8 -*-
"""
Created on Sun Sep 17 18:50:51 2017

@author: Stehvin
"""

def insertionSort(arr):
    """Sorts an "array" (list) using the insertion sort method, where
    the array is sorted from left to right, inserting new elements in 
    their proper place along the way.
    """
    # loop over elements
    for i in range(len(arr)):
        
        # save current element and find the end of the sorted portion
        cur = arr[i]
        j = i - 1
        
        # loop over sorted portion
        while j >= 0:
            
            # move bigger elements up a spot
            if arr[j] > cur:
                arr[j + 1] = arr[j]
                if j == 0:
                    arr[j] = cur
                j -= 1
            
            # the correct location has been found when a smaller
            # element appears            
            else:
                arr[j + 1] = cur
                break
    return arr