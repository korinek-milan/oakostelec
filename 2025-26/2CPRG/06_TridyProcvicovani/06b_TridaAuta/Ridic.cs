using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TridaAuta
{
    internal class Ridic
    {
        public string Jmeno;
        public int Vek;

        //jedno auto
        //public Auto vlastneneAuto;

        //více aut
        public List<Auto> vlastnenaAuta = new List<Auto>();

        public void VratiInfoORidici()
        {
            Console.WriteLine($"Jméno řidiče:  {Jmeno}");
            //Console.WriteLine($"Vlastním: {vlastneneAuto.Nazev}");

            Console.WriteLine("Vlastním:");
            for (int i = 0; i < vlastnenaAuta.Count; i++)
            {
                //volám funkci z toho konkrétního auta
                vlastnenaAuta[i].VratInfoOAute();
            }


            //foreach (Auto item in vlastnenaAuta)
            //{
            //    Console.WriteLine($"Vlastním: {item.Nazev}");
            //}

            //foreach
        }
    }
}
