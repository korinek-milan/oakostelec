using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MujCelyProgram
{
    internal class Knihovna
    {
        Kniha[] bookList;

        public Knihovna()
        {
            bookList = new Kniha[20];
        }

        public void pridejKnihu(Kniha k)
        {
            for (int i = 0; i < bookList.Length; i++)
            {
                if (bookList[i] == null)
                {
                    bookList[i] = k;
                    break;//po pridani knihy uz nechci pokracovat, jinak by mi ji to pridalo na vsechny pozice
                }
            }
        }

        public void vypisKnihy()
        {
            Console.WriteLine("Následuje seznam knih:");

            for(int i = 0; i < bookList.Length; i++)
            {
                if (bookList[i] != null)
                {
                    //neni uplne cisty zpusob jak vypisovat
                    //lepsi by bylo vratit string a at si to vypise ten, kdo
                    //to chce...v tomto pripade Main
                    Console.WriteLine(bookList[i].lepsiInfo());
                }
            }

            Console.WriteLine("To je vše");
        }
    }
}
