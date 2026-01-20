using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SkolaContext())
            {
                db.Database.EnsureCreated();
            }

            using (var db = new SkolaContext())
            {
                /*Trida t = new Trida();// { Nazev = "3.A" };
                t.Nazev = "1.C";

                Trida t2 = new Trida { Nazev = "2.C" };

                db.Tridy.Add(t);
                db.Tridy.Add(t2);

                db.SaveChanges();*/

                /*var vysledek = db.Studenti
                .Where(s => s.Vek > 15)           // filtr podle TridaId
                .Select(s => new                      // vyber jen požadované sloupce
                {
                    s.Id,
                    s.Jmeno
                })
                .ToList();*/
                //select Nazev from Tridy
                var vysledek = db.Tridy
                    .Select(t => new { t.Nazev })
                    .ToList();

                foreach (var v in vysledek)
                {
                    Console.WriteLine(v.Nazev);
                }
            }
        }
    }

    public class SkolaContext : DbContext
    {
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Trida> Tridy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=skola.db");
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trida>()
                .HasIndex(t => t.Nazev)
                .IsUnique();
        }*/
    }

    public class Student
    {
        public int Id { get; set; }           // Primární klíč
        public string? Jmeno { get; set; }
        public int Vek { get; set; }

        //public string Email { get; set; }

        //public int TridaId { get; set; }       // Cizí klíč
        //public Trida? Trida { get; set; }       // Navigační vlastnost
    }

    public class Trida
    {
        public int Id { get; set; }
        public string? Nazev { get; set; }

        //public List<Student>? Studenti { get; set; }
    }
}
