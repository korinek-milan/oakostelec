using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisPC
{
    internal class DatabaseManager
    {
        public List<ServiceTask> vratVsechnyUkony()
        {
            using (var db = new ComputerDbContext())
            {
                return db.ServiceTasks.ToList();
            }

        }

        //public (double, int) vratInfoOUkonuPodleID(int idUkonu)
        public List<double> vratInfoOUkonuPodleID(int idUkonu)
        {
            using (var db = new ComputerDbContext())
            {
                var vysledek = db.ServiceTasks.FirstOrDefault(t => t.ServiceTaskId == idUkonu);

                if (vysledek != null)
                {
                    List<double> vystupniHodnoty = new List<double>();
                    vystupniHodnoty.Add(vysledek.Price);
                    vystupniHodnoty.Add(vysledek.SpecialistCharge);

                    //return new List<double> { vysledek.Price, vysledek.SpecialistCharge };

                    return vystupniHodnoty;
                }
                return new List<double>();
            }
        }
    }
}
