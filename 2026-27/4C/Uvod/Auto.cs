using System;
using System.Collections.Generic;
using System.Text;

namespace Uvod
{
    internal class Auto
    {
        public double MnozstviPaliva { get; protected set; } = 1;
        public string Barva { get; private set; }
        public Auto(string barva)
        {
            Barva = barva;
            MnozstviPaliva = 1;
        }

        
        public virtual void Natankovani(double mnozstviPaliva)
        {
            MnozstviPaliva = MnozstviPaliva + mnozstviPaliva;
        }
    }
}
