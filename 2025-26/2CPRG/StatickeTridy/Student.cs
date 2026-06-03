using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatickeTridy
{
    internal class Student
    {

        public string jmeno;

        public static int pocetVytvorenychStudentu { get; private set; } = 0;

        public Student(string _Jmeno)
        {
            jmeno = _Jmeno;
            pocetVytvorenychStudentu++;
        }

        public string vratJmeno()
        {
            return jmeno;
        }

        public static int vratPocetStudentu()
        {
            return pocetVytvorenychStudentu;
        }


    }
}
