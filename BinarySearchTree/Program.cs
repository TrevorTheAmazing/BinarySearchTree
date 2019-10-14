using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{    
    class Program
    {
        

        //BinarySearchTree newTree = new BinarySearchTree();
        
        static void Main(string[] args)
        {
            Random random = new Random();            
            for (int i = 0; i<10; i++)
            {
                BinarySearchTree newTree = new BinarySearchTree(random.Next(1, 101));
            }
        }
    }
}
