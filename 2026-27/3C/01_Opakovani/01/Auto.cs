using System;
using System.Collections.Generic;
using System.Text;

namespace Opakovani
{
    internal class Auto
    {
        public int rychlost { get; private set; }
        public string barva { get; private set; }

        public Auto(int _rychlost, string barva)
        {
            rychlost = _rychlost;

            this.barva = barva;
        }

        public void ZmenBarvu(string _barva)
        {
            if (_barva != "")
            {
                this.barva = _barva;
            }
        }
    }
}
