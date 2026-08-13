using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdstranovacMezer
{
    static internal class Odstranovac
    {

        public static string remover(string vstup, bool nahradit)
        {
            string mezivysledek = "";

            bool bylZnak = false;
            for (int i = 0; i < vstup.Length; i++)
            {
                if (bylZnak == false)
                {
                    //fáze počátečních mezer
                    if (vstup[i] == ' ')
                    {
                        //počáteční mezera a nic nedělám
                    }
                    else
                    {
                        //kopíruju znak
                        mezivysledek += vstup[i];
                        bylZnak = true;
                    }
                }
                else
                {
                    //už jsem nějaký znak našel...takže kopíruju všechno
                    mezivysledek += vstup[i];
                }
            }

            bylZnak = false;
            string mezivysledek2 = "";
            for (int i = mezivysledek.Length-1; i >= 0; i--)
            {
                if (bylZnak == false)
                {
                    //fáze počátečních mezer
                    if (mezivysledek[i] == ' ')
                    {
                        //počáteční mezera a nic nedělám
                    }
                    else
                    {
                        //kopíruju znak
                        //musím otočit pořadí
                        mezivysledek2 = mezivysledek[i] + mezivysledek2;
                        bylZnak = true;
                    }
                }
                else
                {
                    //už jsem nějaký znak našel...takže kopíruju všechno
                    //musím otočit pořadí
                    mezivysledek2 = mezivysledek[i] + mezivysledek2;
                }
            }

            if (nahradit)
            {
                return mezivysledek2.Replace(' ', '_');
            }

            return mezivysledek2;
        }
    }
}
