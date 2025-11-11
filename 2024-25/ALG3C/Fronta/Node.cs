using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fronta
{
    internal class Node
    {
        public int Value;
        public Node Next;

        public Node(int _Value)
        {
            Value = _Value;
            Next = null;
        }   
    }
}
