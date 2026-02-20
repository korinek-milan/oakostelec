using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Vozidla
{
    internal static class Calculator
    {
        public static double CalculatePrice(Vehicle _Vehicle, Customer _Customer, int Days)
        {
            /* Modifikátor
                 Pokud je věk zákazníka menší než 25, pak je modifikátor 1.6
                 Pokud je věk zákazníka větší 65, pak je modifikátor 1.4
                 Jinak je modifikátor 1*/
            double modifier = 1;
            if (_Customer.Age < 25)
            {
                modifier = 1.6;
            }
            else if (_Customer.Age > 65)
            {
                modifier = 1.4;
            }

               return (_Vehicle.PricePerDay * Days) * modifier;
        }
    }
}
