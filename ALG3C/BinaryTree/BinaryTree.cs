using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class BinaryTree
    {
        Node Root = null;


        public void WhileAdd(int value)
        {
            Node n = new Node(value);
            if (Root == null)
            {
                Root = n;
                return;
            }
            
            Node tmp = Root;

            while (true)
            {
                if (value < tmp.Value)
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
                else
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
            }
        }

        public void Add(int value)
        {
            Node newCreated = SearchAndAdd(Root, value);
            if (newCreated != null)
            {
                Root = newCreated;
            }
        }

        public Node SearchAndAdd(Node inputNode, int value)
        {
            Node n = new Node(value);

            if (inputNode == null)
            {
                return n;
            }

            if (value < inputNode.Value)
            {
                inputNode.Left = SearchAndAdd(inputNode.Left, value);
            }
            else if (value > inputNode.Value)
            {
                inputNode.Right = SearchAndAdd(inputNode.Right, value);
            }
            else
            {
                return null;
            }

            return inputNode;
        }

        public bool Search(int value)
        {
            Node tmp = Root;

            while (tmp != null)
            {
                if (tmp.Value == value)
                {
                    return true;
                }

                if (value < tmp.Value)
                {
                    tmp = tmp.Left;
                    continue;
                }
                else
                {
                    tmp = tmp.Right;
                    continue;
                }
            }

            return false;
        }
    }
}
