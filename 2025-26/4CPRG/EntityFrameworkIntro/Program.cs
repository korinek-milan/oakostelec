using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SkolaContext())
            {
                //db.Database.EnsureCreated();
                db.Database.Migrate();
            }

            /*
             * if (!db.Tridy.Any(t => t.Nazev == "3.A"))
                {
                    db.Tridy.Add(new Trida { Nazev = "3.A" });
                    db.SaveChanges();
                }

            var tridaX = db.Tridy
                  .FirstOrDefault(t => t.Nazev == "3.A");

                

                var student = new Student
                {
                    Jmeno = "Jan Novák",
                    Vek = 17,
                    Trida = tridaX
                };
             */

            using (var db = new SkolaContext())
            {

                if (!db.Tridy.Any(t => t.Nazev == "3.A"))
                {
                    db.Tridy.Add(new Trida { Nazev = "3.A" });
                }


                if (!db.Studenti.Any(t => t.Jmeno == "Karel"))
                {
                    Student s = new Student { Jmeno = "Karel", Vek = 20, Email = "mail@mail.mail" };
                    db.Studenti.Add(s);
                }

                db.SaveChanges();

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
                    .Select(t => new                      // vyber jen požadované sloupce
                    {
                        t.Id,
                        t.Nazev
                    })
                    .Where(t => t.Nazev.Contains("C"))
                    .ToList();

                foreach (var v in vysledek)
                {
                    Console.WriteLine(v.Nazev + " " + v.Id);
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

        public string Email { get; set; }

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
