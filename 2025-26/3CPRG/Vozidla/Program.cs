using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozidla
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DBManager db = new DBManager();
            Vehicle v1 = null;
            //Customer c1 = new Customer(Console.ReadLine());
            Customer c1 = new Customer("Novák");
            Customer c2 = new Customer("Schmid");
            Customer c3 = new Customer("Hryn");
            try
            {
                v1 = db.getVehicleFromDB(2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (v1 != null)
            {
                double price = Calculator.CalculatePrice(v1, c1, 10);
                Console.WriteLine($"Zákazník {c1.Surname} si půjčuje vozidlo {v1.Brand} {v1.Model} za {price} Kč.");
            }

            
        }
    }
}
