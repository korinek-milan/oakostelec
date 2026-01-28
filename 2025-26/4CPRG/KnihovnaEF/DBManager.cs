using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnihovnaEF
{
    internal class DBManager : DbContext
    {
        public DbSet<Regal> Regaly { get; set; }
        public DbSet<Kniha> Knihy { get; set; }

        public DBManager()
        {
            //using (var db = new SkolaContext())
            {
                //db.Database.EnsureCreated();
                this.Database.Migrate();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=knihovna.db");
        }

        public void VytvorRegal(string nazevRegalu)
        {
            Regal r = new Regal { Nazev = nazevRegalu };
            using (var db = new DBManager())
            {
                db.Regaly.Add(r);
                db.SaveChanges();
            }
        }

        public void PridejKnihy(string nazevKnihy, string nazevRegalu)
        {
            using (var db = new DBManager())
            {
                var regalId = db.Regaly
                  .FirstOrDefault(t => t.Nazev == nazevRegalu);

                if (regalId != null)
                {
                    Kniha k = new Kniha { Nazev = nazevKnihy, RegalId = regalId };
                }
            }

                
        }
    }
}
