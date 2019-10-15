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
            //Random random = new Random();
            BinarySearchTree newTree = new BinarySearchTree();
            
            //for (int i = 0; i < 10; i++)
            //{
                //int tempInt = random.Next(1, 101);
                //newTree.Insert(tempInt);

                newTree.Insert(48);
                newTree.Insert(59);
                newTree.Insert(22);
                newTree.Insert(13);
                newTree.Insert(7);
                newTree.Insert(11);
                newTree.Insert(57);
                newTree.Insert(85);
                newTree.Insert(56);
                newTree.Insert(99);

            //}

            try
            {
                Node tempNode = newTree.Find(22);

                if (tempNode != null)
                {
                    Console.WriteLine(tempNode.Data);
                }

                tempNode = newTree.Find(96);
                if (tempNode != null)
                {
                    Console.WriteLine("somehow found 96");
                }
                else if (tempNode == null)
                {
                    Console.WriteLine("did not find 96.");
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
