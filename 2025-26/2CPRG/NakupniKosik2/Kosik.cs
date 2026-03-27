using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakupniKosik
{
    internal class Kosik
    {
        private List<PolozkaKosiku> seznam = new List<PolozkaKosiku>();


        public void PridejPolozku(Produkt p, int mnozstvi)
        {
            PolozkaKosiku pk = new PolozkaKosiku(p, mnozstvi);
            seznam.Add(pk);
        }

        public void OdeberPolozku(Produkt p)
        {
            foreach (PolozkaKosiku item in seznam)
            {
                if(item.vratProdukt() == p)
                {
                    seznam.Remove(item);
                    break;
                }
                
            }
        }

        public string VypisVsechnyPridaneProdukty()
        {
            string text = "";
            //TODO

            return text;
        }


        public double celkovaCena()
        {
            double celkem = 0;

            foreach (PolozkaKosiku item in seznam)
            {
                celkem += item.CenaCelkem();
            }

            return celkem;
        }

        //public void PridejPolozku(Produkt p, int ks)
        //{
        //    //uživatel mi říká (vstupními parametry, jaký produkt a kolik kusů chce přidat do košíku
        //    //já si interně to "seskupím" do jedné instance PolozkaKosiku
        //    PolozkaKosiku pk = new PolozkaKosiku(p, ks);
        //    //...a tuto instanci si přidám do svého listu
        //    seznam.Add(pk);
        //}

        //public double celkovaCena()
        //{
        //    double celkem = 0;

        //    foreach(PolozkaKosiku item in seznam)
        //    {
        //        celkem += item.CenaCelkem();
        //    }
        //    return celkem;
        //}

        //public void OdeberPolozku(Produkt p)
        //{
        //    //seznam.Remove(p);
        //    foreach (PolozkaKosiku item in seznam)
        //    {
        //        if (item.vratProdukt() == p)
        //        {
        //            seznam.Remove(item);
        //            //ve chvíli, kdy změním strukturu listu (Remove/Add), musím nutně zastavit foreach(break) nebo mi to spadne
        //            break;
        //        }
        //    }

        //    //stejná varianta, ale pomocí for cyklu, kde si nejdřív najdu, na jakém indexu leží položka, kterou chci odstranit
        //    //int indexToRemove = -1;
        //    //for (int i = 0; i < seznam.Count; i++)
        //    //{
        //    //    if (seznam[i].vratProdukt() == p)
        //    //    {
        //    //        indexToRemove = i;
        //    //        break;
        //    //    }
        //    //}

        //    //následně odstraním položku z indexu
        //    //if(indexToRemove != -1)
        //    //{
        //    //    seznam.RemoveAt(indexToRemove);
        //    //}
            
        //}
    }
}
