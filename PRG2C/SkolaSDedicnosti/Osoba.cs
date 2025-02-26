using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkolaSDedicnosti
{
    internal class Osoba
    {
        int Age;
        //Name je automaticky (implicitně) private,
        //tedy nevidí na tento atribut ani třída, která dědí z třídy Osoba
        string Name;



        public Osoba(int _AgeOsoby, string _NameOsoby)
        {
            Age = _AgeOsoby;
            Name = _NameOsoby;
            Console.WriteLine("Konstruktor osoby");
        }


        public string Introduce()
        {
            //Znaklem dolaru před uvozovkami říkám, že názvy ve složených závorkách jsou proměnné
            return $"Ahoj, já jsem {Name} a je mi {Age}";
        }
    }
}
