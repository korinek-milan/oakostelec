using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Node
    {
        public int Value;
        public Node Left = null;
        public Node Right = null;

        public Node(int _Value)
        { 
            Value = _Value;
        }
    }
}
