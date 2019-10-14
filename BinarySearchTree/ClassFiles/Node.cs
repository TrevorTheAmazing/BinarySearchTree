using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node<T>
    {
        //member variables
        public T value;
        public Node<int> parentNode;
        public Node<int> leftChild;
        public Node<int> rightChild;
        //public Node<int> currentNode;



        //constructor
        public Node(T valueIn)
        {
            this.value = valueIn;
            this.leftChild = null;
            this.rightChild = null;
            //this.currentNode = null;
        }

        //member methods
    }
}
