using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zasobnik
{
    internal class Queue
    {
        Node Head = null;
        public void Push(int Value)
        {
            Node n = new Node(Value);

            if (Head == null)
            {
                Head = n;
                return;
            }
            else
            {
                n.Next = Head;
                Head = n;
            }

        }

        public Node Pop()
        {
            Node tmp = Head;
            Head = Head.Next;

            return tmp;
        }

        public int Peek()
        {
            return Head.Value;
        }

        public string WriteAll()
        {
            StringBuilder sb = new StringBuilder();
            Node tmp = Head;
            while (tmp != null)
            {
                sb.AppendLine(tmp.Value.ToString());
                tmp = tmp.Next;
            }
            return sb.ToString();
        }

    }
}
