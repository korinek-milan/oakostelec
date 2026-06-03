using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTextZdvojeniAVyskyt
{
    static internal class TextMaker
    {
        static public int kolikrat(char znak, string text)
        {
            int pocetVykystu = 0;

            foreach (char z in text)
            {
                if (z == znak)
                {
                    pocetVykystu++;
                }
            }

            //obě varianty v pořádku
            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == znak)
            //    {
            //        pocetVykystu++;
            //    }
            //}

            return pocetVykystu;
        }

        static public string zdvoj(string text)
        {
            string zdvojenyText = "";

            foreach (char z in text)
            {
                zdvojenyText += z + z;
            }

            //for (int i = 0; i < text.Length; i++)
            //{
            //    zdvojenyText += text[i] + text[i];
            //}

            return zdvojenyText;
        }

    }
}
