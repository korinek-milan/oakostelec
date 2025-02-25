using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MujCelyProgram
{
    public class Kniha
    {
        //protected nebo private, protoze nechci, aby mi do toho někdo hrabal
        protected string Name;
        protected string Author;
        protected int Year;

        public Kniha(string _Name, string _Author, int _Year)
        {
            Name = _Name;
            Author = _Author;
            Year = _Year;
        }

        //vypis o knize, zde osklive reseno pres Console.WriteLine
        //lepsi by bylo override ToString nebo navratova hodnota string
        public virtual void oskliveInfo()
        { 
            Console.WriteLine(this.Name + ", " + this.Author + ", " + this.Year);
        }

        public virtual string lepsiInfo()
        {
            return this.Name + ", " + this.Author + ", " + this.Year;
        }
    }
}