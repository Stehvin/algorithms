# -*- coding: utf-8 -*-
"""
Created on Mon Sep 18 19:30:18 2017

@author: Stehvin
"""

def bubbleSort(arr):
    """Sorts an "array" (list) by swapping adjacent elements. Each pass
    puts the greatest value on the end. Completes after "n" passes through
    the array.
    """
    # loop through array "n" (length of the array) times
    for i in range(len(arr)):
        
        # check/swap adjacent elements
        for j in range(0, len(arr) - 1 - i):
            if arr[j] > arr[j + 1]:
                arr[j], arr[j + 1] = arr[j + 1], arr[j]
    return arr