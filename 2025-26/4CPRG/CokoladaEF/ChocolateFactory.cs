using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokoladaEF
{
    internal class ChocolateFactory
    {
        List<Chocolate> listVyrobenychCokolad = new List<Chocolate>();

        public Chocolate MakeChocolate(string ChocolateName)
        {
            //1. Zjistit, jaké ingredience potřebuji pro vyrobení čokolády s názvem ChocolateName
            //2. Zjistit, kolik od každé ingerdience mám na skladě
            //3. Porovnat to co mám, s tím, co potřebuji
            //4. Vyrobit instanci čokolády


            if (CheckIngredients(ChocolateName) == false)
            {
                return null;
            }

            DatabaseManager dbm = new DatabaseManager();
            ChocolateType receptNapozadovanouCokoladu = dbm.GetChocolateTypeByName(ChocolateName);

            //4. Vyrobit instanci čokolády
            //4a. spotřeboval jsem suroviny ze skladu, musím udělat update
            //4b. ChocolateFactory si drží seznam vyrobených čokolád - přidám právě vyrobenou čokoládu do seznamu
            Chocolate c = new Chocolate(ChocolateName);
            listVyrobenychCokolad.Add(c);

            //receptNapozadovanouCokoladu.CocoaBeans obsahuje množství, které potřebuji
            //když to pošlu jako zápornou hodnotu, tak to odečte
            dbm.RestockIngredient("CocoaBeans", receptNapozadovanouCokoladu.CocoaBeans * -1);
            dbm.RestockIngredient("Sugar", receptNapozadovanouCokoladu.Sugar * -1);
            dbm.RestockIngredient("Milk", receptNapozadovanouCokoladu.Milk * -1);
            dbm.RestockIngredient("CocoaButter", receptNapozadovanouCokoladu.CocoaButter * -1);
            dbm.RestockIngredient("Vanilla", receptNapozadovanouCokoladu.Vanilla * -1);


            return c;
        }



        private bool CheckIngredients(string ChocolateName)
        {
            //1. Zjistit, jaké ingredience potřebuji pro vyrobení čokolády s názvem ChocolateName
            DatabaseManager dbm = new DatabaseManager();
            ChocolateType receptNapozadovanouCokoladu = dbm.GetChocolateTypeByName(ChocolateName);
            if (receptNapozadovanouCokoladu == null)
            {
                return false;
            }


            //2. Zjistit, kolik od každé ingerdience mám na skladě
            List<Ingredient> ingredienceNaSklade = dbm.GetAllIngredients();



            //3. Porovnat to co mám, s tím, co potřebuji
            int cb = receptNapozadovanouCokoladu.CocoaBeans;
            foreach (Ingredient item in ingredienceNaSklade)
            {
                //pro řádek ingredience na skladě, který má v názvu CocoaBeans zkontroluj
                if (item.Ingredient1 == "CocoaBeans")
                {
                    //pokud požadvané množství je větší než množství toho řádku
                    //pak nemá cenu dál pokračovat, čokoládu nemůžu vyrobit a vracím null
                    if (receptNapozadovanouCokoladu.CocoaBeans > item.Amount)
                    {
                        return false;
                    }
                }

                if (item.Ingredient1 == "Sugar")
                {
                    if (receptNapozadovanouCokoladu.Sugar > item.Amount)
                    {
                        return false;
                    }
                }

                if (item.Ingredient1 == "Milk")
                {
                    if (receptNapozadovanouCokoladu.Milk > item.Amount)
                    {
                        return false;
                    }
                }

                if (item.Ingredient1 == "CocoaButter")
                {
                    if (receptNapozadovanouCokoladu.CocoaButter > item.Amount)
                    {
                        return false;
                    }
                }

                if (item.Ingredient1 == "Vanilla")
                {
                    if (receptNapozadovanouCokoladu.Vanilla > item.Amount)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public int RestockIngredient(string IngredientName, int Amount)
        {
            return 0;
        }
    }
}
