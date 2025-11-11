using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //pomoci while
            BinaryTree btw = new BinaryTree();
            btw.WhileAdd(5);
            btw.WhileAdd(3);
            btw.WhileAdd(4);

            //pomocí rekurze
            BinaryTree bt = new BinaryTree();
            bt.Add(5);
            bt.Add(3);
            bt.Add(4);

            bool found = bt.Search(11);

            //inOrder Left->Root->Right
            //postOrder Left->Right->Root
            //preOrder root->Left->Right
        }
    }
}
