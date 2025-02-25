using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolate
{
    internal class ChocolateFactory
    {
        List<Chocolate> chocolates = new List<Chocolate>();
        public Chocolate MakeChocolate(string ChocolateName)
        {
            DatabaseManager manager = new DatabaseManager();
            List<Ingredient> recipe = manager.GetRecipe(ChocolateName);

            if (CheckIngredients(recipe))
            {
                foreach (Ingredient i in recipe)
                {
                    RestockIngredient(i.Name, i.Amount * -1);
                }
                Chocolate c = new Chocolate(ChocolateName);
                chocolates.Add(c);
                return c;
            }

            return null;
        }

        private bool CheckIngredients(List<Ingredient> recipe)
        {
            DatabaseManager manager = new DatabaseManager();

            foreach (Ingredient ing in recipe)
            {
                if(manager.checkIngredient(ing.Name) < ing.Amount)
                {
                    return false;
                }
            }

            return true;
        }

        public int RestockIngredient(string IngredientName, int Amount)
        {
            DatabaseManager manager = new DatabaseManager();
            return manager.Restock(IngredientName,Amount);
        }

        public void RestockAll()
        {
            string[] ingredients = { "CocoaBeans", "Sugar", "Milk", "CocoaButter", "Vanilla" };

            foreach (string i in ingredients)
            {
                RestockIngredient(i, 100);
            }
        }

        public string getMadeChocolates()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Chocolate c in chocolates)
            {
                sb.AppendLine(c.Name);
            }
            return sb.ToString();
        }

        public void eatChocolate(string ChocolateName)
        {
            foreach (Chocolate c in chocolates)
            {
                if (c.Name == ChocolateName)
                { 
                    chocolates.Remove(c);
                    return;
                }
            }
        }

        public string getAllIngredients()
        {
            DatabaseManager manager = new DatabaseManager();
            StringBuilder sb = new StringBuilder();
            foreach (Ingredient i in manager.getAllIngredients())
            {
                sb.AppendLine(i.Name + ": " +  i.Amount);
            }
            return sb.ToString();
        }
    }
}
