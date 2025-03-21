using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihovna
{
    internal class Kniha
    {
        int Id;
        string Name;
        string Author;

        public Kniha(int _Id, string _Name, string _Author)
        {
            Id = _Id;
            Name = _Name;
            Author = _Author;
        }

        public string vratInfo()
        {
            //return Id + " " + Name + " ";
            //Console.WriteLine($"Idcko: {Id}, Jmeno: {Name}, Autor: {Author} ");
            return $"Idcko: {Id}, Jmeno: {Name}, Autor: {Author} ";

        }

        public void PrejmenujSe(string NoveJmeno)
        {
            Name = NoveJmeno; 
        }
    }
}
