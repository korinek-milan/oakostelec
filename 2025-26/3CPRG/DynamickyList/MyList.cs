using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamickyList
{
    internal class MyList
    {
        Node First = null;

        public void Add(int newValue)
        {
            Node n = new Node(newValue);

            if (First == null)
            {
                First = n;
            }
            else
            {
                Node tmp = First;

                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }

                tmp.Next = n;
            }
        }

        public void Remove(int value)
        {
            if (First.Value == value)
            {
                First = First.Next;
            }
            else
            {
                Node tmp = First;
                Node prev = null;

                while (tmp.Value != value)
                {
                    prev = tmp;
                    tmp = tmp.Next;
                }

                prev.Next = tmp.Next;

            }
        }

    }
}
