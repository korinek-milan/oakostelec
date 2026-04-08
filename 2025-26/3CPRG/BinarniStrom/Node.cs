using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarniStrom
{
    internal class Node
    {
        public int Value { get; private set; }
        public Node Left = null;
        public Node Right = null;

        public Node(int value)
        {
            Value = value;
        }
    }
}
