using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{    
    class Program
    {       
        static void Main(string[] args)
        {
            Random random = new Random();
            BinarySearchTree newTree = new BinarySearchTree();
            for (int i = 0; i < 10; i++)
            {
                //newTree.Add(random.Next(1, 101));
                newTree.Insert(75);
                newTree.Insert(57);
                newTree.Insert(90);
                newTree.Insert(32);
                newTree.Insert(7);
                newTree.Insert(44);
                newTree.Insert(60);
                newTree.Insert(86);
                newTree.Insert(93);
                newTree.Insert(99);
            }
        }
    }
}
