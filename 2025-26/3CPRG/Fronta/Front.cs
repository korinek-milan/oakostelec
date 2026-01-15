using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Fronta
{
    internal class Front
    {
        public Node Head;
        public void Push(int value)
        {
            Node n = new Node(value);

            if (Head == null)
            {
                Head = n;
                return;
            }

            Node tmp = Head;
            while (tmp.Next != null)
            {
                tmp = tmp.Next;
            }

            tmp.Next = n;
        }

        public Node Pop()
        {
            if (Head == null)
            {
                return null;
            }

            Node oldHead = Head;
            Head = oldHead.Next;

            return oldHead;
        }

        public int? Peek()
        {
            return Head.Value;
        }
    }
}
