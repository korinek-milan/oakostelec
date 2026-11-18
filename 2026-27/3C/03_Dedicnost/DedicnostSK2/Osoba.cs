using System;
using System.Collections.Generic;
using System.Text;

namespace DedicnostSK2
{
    internal class Osoba
    {
        public string Jmeno;

        public Osoba(string jmeno)
        {
            Jmeno = jmeno;
        }

        public void Login()
        {
            Console.WriteLine("Přihlášeno");
        }
    }
}
