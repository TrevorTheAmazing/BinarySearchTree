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
        private Node root;
        //Random random = new Random();

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
        }

        public Node Find(int data)
        {
            if (root != null)
            {
                return root.Find(data);
            }
            else
            {
                return null;
            }            
        }
    }
}
