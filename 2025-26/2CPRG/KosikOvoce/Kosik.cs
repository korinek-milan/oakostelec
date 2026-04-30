using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Kosik
    {
        List<Ovoce> seznam = new List<Ovoce>();

        public void pridejOvoce(Ovoce o)
        {
            seznam.Add(o);
        }

        public void pridejOvoce(string nazev, double hmotnost)
        {
            Ovoce o = new Ovoce(nazev, hmotnost);
            seznam.Add(o);
        }

        public double soucetHmotnosti()
        {
            double celkem = 0;

            foreach (Ovoce item in seznam)
            {
                celkem += item.hmotnost;
            }

            return celkem;

            //for (int i = 0; i < seznam.Count; i++)
            //{
            //    celkem += seznam[i].hmotnost;
            //}
        }
    }
}
