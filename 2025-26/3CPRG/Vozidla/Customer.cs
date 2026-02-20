using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozidla
{
    internal class Customer
    {
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public Customer(string _Surname)
        {
            Surname = _Surname;
            Random r = new Random();

            Age = r.Next(18,81);
        }
    }
}
