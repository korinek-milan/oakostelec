using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarniStrom
{
    internal class Strom
    {
        Node Root = null;

        public void Add(int value)
        {
            Node n = new Node(value);

            

            if (Root == null)
            {
                Root = n;
            }
            else
            {
                Node tmp = Root;

                while (true)
                {
                    if (tmp.Value == n.Value)
                    {
                        throw new Exception("Hodnota existuje");
                    }
                    else if (tmp.Value < n.Value)
                    {
                        if (tmp.Right == null)
                        {
                            tmp.Right = n;
                            break;
                        }
                        else
                        {
                            tmp = tmp.Right;
                        }

                    }
                    else
                    {
                        if (tmp.Left == null)
                        {
                            tmp.Left = n;
                            break;
                        }
                        else
                        {
                            tmp = tmp.Left;
                        }

                    }
                }
            }
        }
    }
}
