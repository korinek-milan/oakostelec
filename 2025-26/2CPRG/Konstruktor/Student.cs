using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor
{
    internal class Student
    {
        //všechno si dám private, aby mi to nemohl upravovat nikdo z venku bez jakékoliv možnosti kontroly
        private string Jmeno;
        private int RokNarozeni;
        private int Vek;
        private Adresa Adresa;

        
        //Konstruktor je "funkce", která se spustí automaticky při vytvoření instance
        //Mohu ji použít pro naplnění atributů
        public Student(string _Jmeno, int _RokNarozeni, Adresa _Adresa)
        {
            Jmeno = _Jmeno;
            RokNarozeni = _RokNarozeni;
            Adresa = _Adresa;

            //toto je přesně to místo, kde si mohu hlídat, co mi uživatel poslal na vstupu a pokud mi poslal nesmysl, mohu vyhodit chybu
            //kdyby byl atribut public, tuto kontrolu udělat nemohu
            if (_RokNarozeni < 1900)
            {
                throw new Exception("Tento rok je neplatný");
            }
        }

        //pokud bych měl věk i rok narození public, mohu nastavit RokNarození = 2025 a věk = 50
        //data jsou nekonzistentní, proto zde mám funkci nastavVek() a ta si to nějak sama zařídí a nestane se, že budu mít chybu v datech
        public void nastavVek()
        {
            Vek = DateTime.Now.Year - RokNarozeni;
        }

        public int VratVek()
        {
            return Vek;
        }

        //nevypisuji přímo, protože některé aplikace nemusí znát Console a tato třída by pak nebyla univerzální
        //pouze vrátím string, kdo si to chce vypsat, ať si to vypíše - to už není moje starost
        public string vypis()
        {
            return "Jmenuji se: " + Jmeno + " Narodil jsem se v roce: " + RokNarozeni;
        }
    }
}
