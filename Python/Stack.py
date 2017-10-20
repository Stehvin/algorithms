# -*- coding: utf-8 -*-
"""
Created on Thu Oct 19 18:19:06 2017

@author: Stehvin
"""

class Node:
    """Node object can hold a value and a 'pointer' to another node."""
    def __init__(self, value=None):
        self.value = value
        self.nextNode = None
        
    def __str__(self):
        return str(self.value)
        
class Stack:
    """Stack object allows new nodes to be added to the top of a linked list.
       Also, objects can only be removed from the top.
    """
    def __init__(self):
        self.top = None
        
    def push(self, value):
        
        # initialize first node in empty stack
        if self.top == None:
            self.top = Node(value)
        
        # set new top node, and link top node to node directly beneath        
        else:
            second = self.top
            self.top = Node(value)
            self.top.nextNode = second
            
    def pop(self):
        if self.top:
            popVal = self.top.value
            self.top = self.top.nextNode
            return popVal
        return None
    
    def __str__(self):
        
        # print empty stack
        if self.top == None:
            return "Stack()"
            
        # print non-empty stack
        cur = self.top
        output = "Stack(" + str(cur)
        while cur.nextNode:
            cur = cur.nextNode
            output += ", " + str(cur)
        return output + ")"
    

A = Stack()
A.push(3)
A.push(4)
A.push(45)
print(A)
B = A.pop()
print(A)
C = A.pop()
print(A)
D = A.pop()
print(A)
            