using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Knihovna
{
    internal class Ekniha: Kniha
    {
        public int SizeMB;

        public Ekniha(int _Id, string _Name, string _Author,int _SizeMB): base(_Id, _Name, _Author)
        {
            SizeMB = _SizeMB;
        }

        public override string vratInfo()
        {
            string s = base.vratInfo();
            string celeNoveInfo = s + $"Velikost: {SizeMB}";
            return celeNoveInfo;

            //tímto zahodím vše, co dělá rodič a udělám si to podle sebe
            //return $"Idcko: {Id}, Jmeno: {Name}, Autor: {Author}, Velikost: {SizeMB} ";
        }
    }

}
