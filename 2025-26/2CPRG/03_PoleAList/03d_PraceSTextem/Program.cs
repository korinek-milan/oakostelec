using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraceSTextem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "ahoj";
            char c = '@';

            Console.WriteLine(text[1]);

            text = "@" + text;
            Console.WriteLine(text);

            string cistyText = "ahoj";
            string novyText = "";
            for (int i = 0; i < cistyText.Length; i++)
            {
                if (i == 2)
                {
                    novyText += "&pridanyText&";
                }
                
                novyText += cistyText[i];
                //stejný zápis, jen rozepsaný
                //novyText = novyText + text[i];
            }

            //vestavěná funkce na vložení textu na nějakou pozici
            //cistyText.Insert();

            //vestavěná funkce na přehození znaků
            char[] cc = text.Reverse().ToArray();
            foreach (char c1 in cc)
            {
                //funkce Write píše na jeden řádek (WriteLine napíše text a přidá sama enter)
                Console.Write(c1);
            }
            Console.WriteLine();

            Console.WriteLine(text);

            Console.WriteLine(novyText);

        }
    }
}
