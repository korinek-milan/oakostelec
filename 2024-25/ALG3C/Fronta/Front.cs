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
        public bool Push(int value)
        {
            Node n = new Node(value);

            if (Head == null)
            {
                Head = n;
                return true;
            }
            else
            {
                Node tmp = Head;
                while(tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = n;
                return true;
            }
        }

        public Node Pop()
        {
            Node oldHead = Head;
            Head = oldHead.Next;

            return oldHead;
        }

        public int Peek()
        {
            return Head.Value;
        }
    }
}
