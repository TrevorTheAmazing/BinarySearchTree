﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        //member variables
        public Node<int> start;
        public Node<int> currentNode;


        //constructor
        public BinarySearchTree()
        {

        }
        
        //member methods       
        public void Add(int valueIn)
        {
            
            
            Node<int> node = new Node<int>(valueIn);

            //determine position
            //1. Set the parent node to be the current node, which is the root node.
            if (start==null)
            {
                start = node;
            }
            //2a. If the data value in the new node is less than the data value in the current node, 
            else if (valueIn<start.value)
            {
                //set the current node to be the left child of the current node.
                //node.leftChild
                //3a. If the value of the left child of the current node is null, 
                if (currentNode.leftChild == null)
                {
                    //insert the new node here and exit the loop.
                }
                else
                {
                    //3b. Otherwise, skip to the next iteration of the While loop.
                    //break
                }
            }
            //2b.If the data value in the new node is greater than the data value in the 
            //current node, 
            else if (valueIn>currentNode.value)
            {
                //skip to Step 4.
                //4. Set the current node to the right child node of the current node.
                //5a. If the value of the right child of the current node is null, 
                if (currentNode.rightChild == null)
                {
                    //insert the new node here and exit the loop.
                }
                else
                {
                    //5b. Otherwise, skip to the next iteration of the While loop
                    //break;
                }
            }                                   
        }

        public Node<int> Search(int keyIn, Node<int> nodeIn)
        {
            Node<int> currentNode = nodeIn;
            //this is the three-way comparison subroutine
            //1. begin by examining the root node. 
            //2. If the tree is null, 
            //the key we are searching for does not exist in the tree.
            //3a. Otherwise, if the key equals that of the root, 
            //the search is successful and we return the node.
            //3b. If the key is less than that of the root, 
            //we search the left subtree. 
            //3c. Similarly, if the key is greater than that of the root, we search the right subtree. This process is repeated until the key is found or the remaining subtree is null.If the searched key is not found after a null subtree is reached, then the key is not present in the tree. This is easily expressed as a recursive algorithm(implemented in Python): 
            return currentNode;
        }
    }
}