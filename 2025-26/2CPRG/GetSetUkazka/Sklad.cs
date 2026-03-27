using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetUkazka
{
    internal class Sklad
    {
        private List<Boty> SeznamBotNaSkladě = new List<Boty>();

        public void pridejDoSeznamu(Boty b)
        {
            SeznamBotNaSkladě.Add(b);
        }

        public string vypisVsechnyCeny()
        {
            string vystup = "";

            foreach (Boty item in SeznamBotNaSkladě)
            {
                vystup += item.vratCenu().ToString() + "\n";
            }

            return vystup;
        }

        //ošklivá varianta
        public void vypisVsechnyCeny2()
        {
            foreach (Boty item in SeznamBotNaSkladě)
            {
                Console.WriteLine(item.vratCenu().ToString());
            }
        }

        public List<double> vratVsechnyCeny()
        {
            List<double> ceny = new List<double>();

            foreach (Boty item in SeznamBotNaSkladě)
            {
                ceny.Add(item.vratCenu());
            }

            return ceny;
        }

        public List<Boty> vratBotyNaSklade()
        {
            return SeznamBotNaSkladě;
        }
    }
}
