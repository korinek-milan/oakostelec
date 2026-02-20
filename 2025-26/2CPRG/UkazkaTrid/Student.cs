using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkazkaTrid
{

    internal class Student
    {
        public int Vek;
        public int RokNarozeni;
        public string Jmeno;
        //atribut může být typu "jiná třída", ale zapisuje se stejně -> public - datový typ - název
        public Predmet OblibenyPredmet;
        public Predmet NeoblibenyPredmet;


        public void InfoOStudentovi()
        {
            Console.WriteLine($"Jmenuji se: {Jmeno}");
            Console.WriteLine($"Narodil jsem se v roce: {RokNarozeni}");

            //tím, že nemusí být odkaz naplněn tak v základu každý odkaz míří na hodnotu null
            //ve výpisu by se mohlo stát, že chci vypsat název z null a program spadne, protože "null" žádný atribut (ani název) nemá,
            //proto se musím nejdřív zeptat, jestli ten můj atribut je nenulový, tzn. míří "někam"
            if (OblibenyPredmet != null)
            {
                Console.WriteLine($"Oblíbený předmět: {OblibenyPredmet.Nazev}");
            }
            else
            {
                Console.WriteLine("Student nemá oblíbený předmět");
            }
        }

        public void Uceni(int PocetHodin)
        {
            Console.WriteLine($"Jmenuji se: {Jmeno} a Učím se {PocetHodin} hodin");
        }

    }
}
