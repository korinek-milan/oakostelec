using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamickyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nové pole pro 5 prvku, s velikostí není možné hýbat
            int[] pole = new int[5];

            //dynamický list, který nemá předem danou délku
            List<int> seznam = new List<int>();

            //když přidávám, musím říct na jaký index
            pole[0] = 5;

            //když přidávám, jen řeknu "přidej"
            seznam.Add(5);
            seznam.Insert(0, 42);//ale také mohu říct, na jaký index a celý list se posune 
        }
    }
}
