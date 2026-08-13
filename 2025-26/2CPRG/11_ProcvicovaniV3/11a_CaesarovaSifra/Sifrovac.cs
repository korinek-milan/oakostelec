using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CaesarovaSifra
{
    static internal class Sifrovac
    {
        static char[] abeceda = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public static string sifruj(string slovo, int posun)
        {
            string vystup = "";
            foreach (char c in slovo.ToLower())
            {
                for (int i = 0; i < abeceda.Length; i++)
                {
                    if (c == abeceda[i])
                    {
                        if (i + posun >= abeceda.Length)
                        {
                            int p = (i + posun) - abeceda.Length;
                            vystup += abeceda[p];
                        }
                        else if (i + posun < 0)
                        {
                            int p = (i + posun) + abeceda.Length;
                            vystup += abeceda[p];
                        }
                        else
                        {
                            vystup += abeceda[i + posun];
                        }
                        
                        break;
                    }
                    //nove c = abeceda[i + posun]
                }
            }

            return vystup;
        }

        public static string sifrujORD(string slovo, int posun)
        {
            string vystup = "";
            foreach (char c in slovo.ToLower())
            {
                //todo - pracujeme s číselnými hodnotami znaků -> ascii
            }

            return vystup;
        }
    }
}
