using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MujCelyProgram
{
    internal class EKniha : Kniha
    {
        protected int Size;

        public EKniha(string _Name, string _Author, int _Year, int _Size) :base(_Name, _Author, _Year)
        {
            Size = _Size;
        }

        public override string lepsiInfo()
        {
            //return this.Name + ", " + this.Author + ", " + this.Year + ", " + this.Size;
            return base.lepsiInfo() + ", " + this.Size + " MB";
        }

    }
}
