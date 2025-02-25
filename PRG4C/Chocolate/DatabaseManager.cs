using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Chocolate
{
    internal class DatabaseManager
    {
        SQLiteConnection conn;
        public DatabaseManager()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string file = "\\chocolateDB.db";
            string path = workingDirectory + file;
            conn = new SQLiteConnection($"Data Source={path};");
        }

        public List<Ingredient> GetRecipe(string ChocolateName)
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT CocoaBeans,Sugar,Milk,CocoaButter,Vanilla FROM ChocolateType WHERE name = '{ChocolateName}'";
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            //list.Add(new Ingredient("CocoaBeans", Convert.ToInt32(reader["CocoaBeans"])));
            ingredients.Add(new Ingredient("CocoaBeans",Convert.ToInt32(reader["CocoaBeans"])));
            ingredients.Add(new Ingredient("Sugar", Convert.ToInt32(reader["Sugar"])));
            ingredients.Add(new Ingredient("Milk", Convert.ToInt32(reader["Milk"])));
            ingredients.Add(new Ingredient("CocoaButter", Convert.ToInt32(reader["CocoaButter"])));
            ingredients.Add(new Ingredient("Vanilla", Convert.ToInt32(reader["Vanilla"])));
            reader.Close();
            conn.Close();
            return ingredients;
        }

        public int checkIngredient(string IngredientName)
        {
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT amount FROM Ingredients WHERE ingredient = '{IngredientName}'";
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int amount = Convert.ToInt32(reader["amount"]);
            reader.Close();
            conn.Close();

            return amount;
        }

        public int Restock(string IngredientName, int Amount)
        {
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"UPDATE Ingredients SET amount = amount + {Amount} WHERE ingredient = '{IngredientName}';";
            cmd.ExecuteNonQuery();

            conn.Close();

            return checkIngredient(IngredientName);
        }

        public List<Ingredient> getAllIngredients()
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT ingredient, amount FROM Ingredients";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ingredients.Add(new Ingredient(reader["ingredient"].ToString(), Convert.ToInt32(reader["amount"])));
            }
            reader.Close();
            conn.Close();
            return ingredients;
        }
    }
}
