using System;
using System.Collections.Generic;
using System.Text;

namespace Uvod
{
    internal class SpecializovaneAuto : Auto
    {
        public SpecializovaneAuto(string barva) : base(barva)
        {
            
        }

        public override void Natankovani(double mnozstviPaliva)
        {
            MnozstviPaliva = MnozstviPaliva + (mnozstviPaliva/2);
        }

    }
}
