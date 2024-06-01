using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.Trees
{
    public class Models
    {
        public class Node
        {
            public int Key { get; set; }
            public Node? Left { get; set; } 
            public Node? Right { get; set; }

            public Node(int key)
            {
                Key = key;
                Left = null;
                Right = null;
            }
        }

        public class BinaryTree
        {
            public Node? root { get; set; }

            public int length { get; set; } = 0;

            public BinaryTree(Node rootNode)
            {
                root = rootNode;
                length = 1;
            }

            

        }
    }
}
