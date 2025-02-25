using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticCalculator
{
    internal static class Kalkulacka
    {
        public const double PI = 3.14159265358979323846;
        public static double PISpatne = 3.14159265358979323846;

        public static int pocetPouziti = 0;

        public static float soucet(float x, float y)
        {
            pocetPouziti++;
            return x + y;
        }

        public static float rozdil(float x, float y)
        {
            pocetPouziti++;
            return x - y;
        }
    }
}
