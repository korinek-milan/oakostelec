using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Kalkulacka
    {
        public int deleni(int x, int y)
        {
            if (x > 10)
            {
                return x / y;
            }
            else
            {
                //Kalkulacka k = new Kalkulacka();
                //Exception E = new Exception("Požadavek na první číslo je, aby bylo větší než 10");
                //throw E;

                //Random r = new Random();
                //r.Next();

                //int z = new Random().Next();
                


                throw new Exception("Požadavek na první číslo je, aby bylo větší než 10");
            }

        }
    }
}
