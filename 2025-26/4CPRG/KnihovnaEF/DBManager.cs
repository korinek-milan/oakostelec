using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnihovnaEF
{
    internal class DBManager
    {

        public DBManager()
        {
            using (var db = new KnihovnaContext())
            {
                //db.Database.EnsureCreated();
                db.Database.Migrate();
            }
        }

        public void VytvorRegal(string nazevRegalu)
        {
            Regal r = new Regal { Nazev = nazevRegalu };
            using (var db = new KnihovnaContext())
            {
                db.Regaly.Add(r);
                db.SaveChanges();
            }
        }

        //Zde si najdu ručně ID regálu podle názvu, Do RegalId knihy toto id uložím, samo se to prováže s regálem přes ID
        public void PridejKnihu(string nazevKnihy, string nazevRegalu)
        {
            using (var db = new KnihovnaContext())
            {
                var hledanyRegal = db.Regaly
                  .FirstOrDefault(t => t.Nazev == nazevRegalu);

                if (hledanyRegal != null)
                {
                    //Vytvořím instanci knihy včetně ID
                    Kniha k = new Kniha { Nazev = nazevKnihy, RegalId = hledanyRegal.Id };
                    //Knihu přdám do DB
                    db.Knihy.Add(k);
                    db.SaveChanges();
                }
            }
        }

        //Zde si najdu regál, ale pomocí funkce Include si natáhnu i list Knih
        //Poté nepřidávám knihu do DB, ale přidávám ji do listu Regálu, sama se pak přidá do tabulky Knihy
        public void PridejKnihu2(string nazevKnihy, string nazevRegalu)
        {
            using (var db = new KnihovnaContext())
            {
                //nesmím zapomenout na Include, který si stáhne z DB list knih, bez toho by byl null a nefunguje
                var hledanyRegal = db.Regaly
                  .Include(t => t.Knihy)
                  .FirstOrDefault(t => t.Nazev == nazevRegalu);

                if (hledanyRegal != null)
                {
                    //ID regálu neřeším
                    Kniha k = new Kniha { Nazev = nazevKnihy };

                    //Přidám přímo do regálu, ID se tím u knihy vyplní samo
                    hledanyRegal.Knihy.Add(k);
                    // db.Knihy.Add(k);
                    db.SaveChanges();
                }
            }
        }
    }
}
