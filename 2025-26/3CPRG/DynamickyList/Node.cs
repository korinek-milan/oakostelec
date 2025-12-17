using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamickyList
{
    internal class Node
    {
        public int Value;
        public Node Next = null;

        public Node(int newValue)
        {
            Value = newValue;
        }
    }
}
