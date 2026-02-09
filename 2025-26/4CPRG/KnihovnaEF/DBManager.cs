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

        public void PridejKnihu(string nazevKnihy, string nazevRegalu)
        {
            using (var db = new KnihovnaContext())
            {
                var hledanyRegal = db.Regaly
                  .FirstOrDefault(t => t.Nazev == nazevRegalu);

                if (hledanyRegal != null)
                {
                    Kniha k = new Kniha { Nazev = nazevKnihy, RegalId = hledanyRegal.Id };
                    db.Knihy.Add(k);
                    db.SaveChanges();
                }
            }
        }
    }
}
