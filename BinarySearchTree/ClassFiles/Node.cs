using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        //member variables
        private int data;
        public int Data
        {
            get { return data; }
        }
        private Node leftChild;
        public Node LeftChild
        {
            get { return leftChild; }
            set { leftChild = value; }
        }
        private Node rightChild;
        public Node RightChild
        {
            get { return rightChild; }
            set { rightChild = value; }
        }

        //constructor
        public Node(int value)
        {
            data = value;            
        }

        //member methods
        public void Insert(int value)
        {
            if (value >= data)
            {
                if (rightChild == null)
                {
                    rightChild = new Node(value);
                }
                else
                {
                    rightChild.Insert(value);
                }
            }
            else
            {
                if (leftChild == null)
                {
                    leftChild = new Node(value);
                }
                else
                {
                    leftChild.Insert(value);
                }
            }
        }

        public Node Find(int value)
        {
            Node currentNode = this;

            while (currentNode != null)
            {
                if (value == currentNode.data)
                {
                    return currentNode;
                }
                else if (value > currentNode.data)
                {
                    currentNode = currentNode.rightChild;
                }
                else
                {
                    currentNode = currentNode.leftChild;
                }
            }
            return null;
        }
           
    }
}
