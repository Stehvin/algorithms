# -*- coding: utf-8 -*-
"""
Created on Mon Sep 18 19:50:22 2017

@author: Stehvin
"""

def binarySearch(arr, val):
    """Searches a sorted "array" (list) for a value using a 
    divide-and-conquer approach. At each step, one half of the array is 
    thrown out, based on whether the search value is less than or greater
    than the middle value.
    """
    # initialize starting values
    high = len(arr) - 1
    low = 0
    mid = high//2   
    
    # loop until the value is found
    while arr[mid] != val:
        
        # if the search value is less than the middle value, throw out
        # the right side, otherwise, throw out the left side
        if arr[mid] > val:
            high = mid - 1
        else:
            low = mid + 1
        
        # return None if value could not be found in array
        if high < low:
            return None
        
        # calculate new middle index        
        mid = (high + low)//2
    return mid