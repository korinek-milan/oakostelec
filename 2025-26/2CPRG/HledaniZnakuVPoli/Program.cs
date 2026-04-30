using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HledaniZnakuVPoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] poleZnaku = new string[] {"a", "b", "c" };
            char[] poleCharu = new char[] { 'a', 'b', 'c' };

            List<string> list = new List<string>() { "a", "b", "c" };

            Console.WriteLine(NajdiZnak(poleZnaku, "c"));
        }

        static bool NajdiZnakVListu(List<string> list, string hledanyZnak)
        {
            if (list.Contains(hledanyZnak))
            {
                return true;
            }

            return false;
        }

            static bool NajdiZnak(string[] pole, string hledanyZnak)
        {
            foreach (string item in pole)
            {
                if (item == hledanyZnak)
                {
                    return true;
                }
            }

            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] == hledanyZnak)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
