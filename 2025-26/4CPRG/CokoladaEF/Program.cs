using CokoladaEF.Models;
using Microsoft.EntityFrameworkCore;

namespace CokoladaEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                1. přesunout db soubor ze zadání do složky s projektem
                2. Nastavit na db Akce sestavení = obsah, kopírovat do výstupního adresáře - pokud novější
                3. Připravit příkaz, kde bude relativní cesta k souboru projektu
                3.A Přidat parametr Namespace
                3.B Upravit OutputDir např. na Models/Generated
             */

            //tento příkaz zde být nemusí, jen si ho sem odložím, než ho vložím do konzole
                                             //relativní cesta                                     Namespace podle mého projektu        složka Generated, abych věděl, že do těchto souborů nemám hrabat 
            //Scaffold - DbContext "Data Source=chocolateDB.db" Microsoft.EntityFrameworkCore.Sqlite -Namespace CokoladaEF.Models -OutputDir Models/Generated -Force

            using (var db = new ChocolateDbContext())
            {
                //select všech ingrediencí a uložení do listu
                var ingredients = db.Ingredients
                    .ToList();

                //vypíšu pomocí spešl funkce, kteoru jsem si
                //udělal v partial třídě, tzn. ne v té vygenerované
                foreach (var c in ingredients)
                {
                    Console.WriteLine(c.vratIngredience());
                }
            }

            //pro Update hodnoty v db si nejdřív stáhnu data z DB do instance
            //následně instanci upravím a uložím db
            //(instance je přes ID interně pořád svázaná s řádkem v DB)
            using (var db = new ChocolateDbContext())
            {
                var typCokolady = db.ChocolateTypes
                    .FirstOrDefault(c => c.Name == "Milky");

                if (typCokolady != null)
                {
                    typCokolady.CocoaBeans = 50;
                    db.SaveChanges();
                }
            }
        }
    }
}
