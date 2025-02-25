using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamickaStruktura
{
    internal class MyLinkedList
    {
        Node head = null;
        Node tail = null;

        public void Add(int value)
        {
            Node u = new Node(value);
            if ( tail == null)
            {
                head = u;
                tail = u;
            }
            else
            {
                tail.Next = u;
                tail = u;
            }
        }

        public string Print()
        {
            Node t = head;
            string s = "";
            while(t.Next != null)
            {
                s = s + t.Value + "\n";
                t = t.Next;
            }

            s = s + t.Value + "\n";

            return s;
        }
    }
}
