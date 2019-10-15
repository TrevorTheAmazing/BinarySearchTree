using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        //member variables
        //public Node<int> start;
        private Node root;
        Random random = new Random();

        //constructor
        public BinarySearchTree()
        {
            
            
        }
        
        //member methods       
        public void Insert(int data)
        {
            if (root != null)
            {
                root.Insert(data);
            }
            else
            {
                root = new Node(data);
            }
        }//Add()

        public Node Search(int keyIn, Node nodeIn)
        {
            Node root = nodeIn;
            //this is the three-way comparison subroutine
            //1. begin by examining the root node. 
            //2. If the tree is null, 
            //the key we are searching for does not exist in the tree.
            //3a. Otherwise, if the key equals that of the root, 
            //the search is successful and we return the node.
            //3b. If the key is less than that of the root, 
            //we search the left subtree. 
            //3c. Similarly, if the key is greater than that of the root, we search the right subtree. This process is repeated until the key is found or the remaining subtree is null.If the searched key is not found after a null subtree is reached, then the key is not present in the tree. This is easily expressed as a recursive algorithm(implemented in Python): 
            return root;
        }
    }
}
