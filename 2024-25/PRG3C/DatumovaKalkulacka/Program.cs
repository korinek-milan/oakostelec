using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatumovaKalkulacka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;


            string formattedDate = now.ToString("D", System.Globalization.CultureInfo.CurrentCulture);
            Console.WriteLine(formattedDate);

            string formattedDateENUS = now.ToString("D", CultureInfo.CreateSpecificCulture("en-US"));
            Console.WriteLine(formattedDateENUS);




            Console.WriteLine(now.ToString("yyyy"));


        }
    }
}
