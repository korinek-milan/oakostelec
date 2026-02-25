using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CokoladaEF
{
    internal class DatabaseManager
    {
        //vrací celou tabulku všech ingrediencí
        public List<Ingredient> GetAllIngredients()
        {
            using (var db = new ChocolateDbContext())
            {
                var Ingredients = db.Ingredients
                    .ToList();

                return Ingredients;
            }
        }

        //dle zadaného názvu mi zkusí vyhledat recept na danou čokoládu
        public ChocolateType GetChocolateTypeByName(string ChocolateName)
        {
            using (var db = new ChocolateDbContext())
            {
                var CT = db.ChocolateTypes
                    .FirstOrDefault(t => t.Name == ChocolateName);

                return CT;
            }
        }

        //public int RestockIngredient(string IngredientName, int Amount)
        public int RestockIngredient(string IngredientName, int Amount)
        {
            using (var db = new ChocolateDbContext())
            {
                var hledanaIngredience = db.Ingredients
                  .FirstOrDefault(t => t.Ingredient1 == IngredientName);

                if (hledanaIngredience != null)
                {
                    hledanaIngredience.Amount += Amount;
                    db.SaveChanges();

                    return hledanaIngredience.Amount;
                }
            }
            return 0;
        }
    }
}
