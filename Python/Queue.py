# -*- coding: utf-8 -*-
"""
Created on Thu Oct 19 19:33:49 2017

@author: Stehvin
"""

class Node:
    def __init__(self, value=None):
        self.value = value
        self.nextNode = None
    
    def __str__(self):
        return str(self.value)

class Queue:
    def __init__(self):
        self.first = None
        self.last = None

    def enqueue(self, value):
        if self.last == None:
            self.last = Node(value)
            self.first = self.last
        else:
            secondLast = self.last
            self.last = Node(value)
            secondLast.nextNode = self.last
    
    def dequeue(self):
        if self.first:
            returnVal = self.first.value
            self.first = self.first.nextNode
            return returnVal
        return None
    
    def __str__(self):
        
        # print empty queue
        if self.first == None:
            return "Q()"
        
        # print non-empty queue
        cur = self.first
        output = "Q(" + str(cur.value)
        while cur.nextNode:
            cur = cur.nextNode
            output += ", " + str(cur.value)
        return output + ")"

        
A = Queue()
A.enqueue(64)
A.enqueue(24)
A.enqueue(19)
print(A)
B = A.dequeue()
print(A)
C = A.dequeue()
print(A)
A.enqueue(43)
print(A)
D = A.dequeue()
print(A)