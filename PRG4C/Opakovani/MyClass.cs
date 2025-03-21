using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opakovani
{
    internal class MyClass
    {
        string name;
        int age;
        public string myMethod()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("abc");
            sb.Append("de");
            sb.AppendLine("f");

            return sb.ToString();
        }

        public string myABC()
        {
            return "Abc";
        }

        //pokud nepoužívám override ToString(), můžu si udělat prostě svoji vypisovací metodu
        public string getInfo()
        {
            return name + " " + age.ToString();
        }

        //vlastní ToString - abych mohl používat zažitou metodu ToString()
        public override string ToString()
        {
            return name + " " + age.ToString();
        }
    }
}
