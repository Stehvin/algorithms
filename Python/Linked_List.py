# -*- coding: utf-8 -*-
"""
Created on Wed Oct 18 18:30:11 2017

@author: Stehvin
"""

class node:
    """Node object can hold a value and a 'pointer' to another node.
    """
    def __init__(self, value=None, nextNode=None):
        self.value = value
        self.nextNode = nextNode
        
    def __str__(self):
        return str(self.value)

class LinkedList:
    """LinkedList object keeps track of the first (head) and last (tail)
       nodes, forming a chain of nodes.
    """
    def __init__(self):
        self.head = None
        self.tail = None
    
    def insert(self, value):
        """Insert a new node into the linked list."""
        
        # initialize first node in previously empty linked list
        if self.head == None:
            self.tail = node(value)
            self.head = self.tail
            
        # subsequent nodes must be referenced by their previous node
        else:
            self.tail.nextNode = node(value)
            self.tail = self.tail.nextNode
            
    def __str__(self):
        """Print the linked list."""
        if self.head == None:
            return "LL()"
        else:
            cur = self.head            
            output = "LL(" + str(cur.value)
            while cur.nextNode != None:
                cur = cur.nextNode
                output += ", " + str(cur)
            return output + ")"

A = LinkedList()
A.insert(4)
A.insert(2)
A.insert(5)
print(A)
            
            