using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VodniNadrz
{
    internal class VodniNadoba
    {
        double MaxObjem;
        double AktualniObjem = 0;

        public VodniNadoba(double _MaxObjem)
        {
            MaxObjem = _MaxObjem;

        }

        public void pridejVodu(double VodaVLitrech)
        {
            if ((AktualniObjem + VodaVLitrech) <= MaxObjem)
            {
                AktualniObjem += VodaVLitrech;
            }
        }

        public void odeberVodu(double VodaVLitrech)
        {
            if (AktualniObjem - VodaVLitrech >= 0)
            {
                AktualniObjem -= VodaVLitrech;
            }
        }

        public double KolikJeVody()
        {
            return AktualniObjem;
        }

    }
}
