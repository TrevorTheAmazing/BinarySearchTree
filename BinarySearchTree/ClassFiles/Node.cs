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
                    new Node(value);
                }
                else
                {
                    rightChild.Insert(data);
                }
            }
            else
            {
                if (leftChild == null)
                {
                    leftChild = new Node(data);
                }
                else
                {
                    leftChild.Insert(data);
                }
            }
        }
    }
}
