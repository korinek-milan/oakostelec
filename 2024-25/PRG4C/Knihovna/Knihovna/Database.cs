using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;
using MujCelyProgram;
using System.IO;

namespace MujCelyProgram
{
    internal class Database
    {
        static string path;
        SQLiteConnection sqlite_conn;

        public Database()
        {
            //vrací cestu ke složce projektu debug nebo release podle toho, co si vybereme při kompilaci projektu
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Složka nebo soubor, který je relativní k projektu
            string relativePath = "data\\database.db"; // Např. "data\mujSoubor.txt" nebo jen "soubor.txt"

            // Kombinace základní cesty a relativní cesty
            string filePath = Path.Combine(baseDirectory, relativePath);

        
            //klíčové slovo using říká, pokud instance v závorkách implementuje metodu Dispose(), tak po ukončení platnosti using (konec složených závorek) se tato metoda automaticky zavolá
            //v praxi to vypadá tak, že SQLiteConnection v metodě Dispose() bude mít connection.close(), proto jej nemusíme na konci volat
            //Otevření databáze open() stále volám ručně
            using (sqlite_conn = new SQLiteConnection($"Data Source={filePath};Version=3;"))
            { 
                //i přes using musím ručně otevřít
                sqlite_conn.Open();

                SQLiteCommand sqlite_cmdCreate = sqlite_conn.CreateCommand();
                sqlite_cmdCreate.CommandText = "CREATE TABLE IF NOT EXISTS SampleTable(Col1 VARCHAR(20), Col2 INT)";
                sqlite_cmdCreate.ExecuteNonQuery();

                SQLiteCommand sqlite_cmdInsert = sqlite_conn.CreateCommand();
                string input = "test parametru;drop table SampleTable;";
                sqlite_cmdInsert.CommandText = "INSERT INTO SampleTable(Col1, Col2) VALUES($input, 1); ";
                sqlite_cmdInsert.Parameters.AddWithValue("$input", input);
                sqlite_cmdInsert.ExecuteNonQuery();

                SQLiteCommand sqlite_cmdSelect = sqlite_conn.CreateCommand();
                sqlite_cmdSelect.CommandText = "SELECT * FROM SampleTable";

                SQLiteDataReader sqlite_datareader = sqlite_cmdSelect.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    string col1 = sqlite_datareader.GetString(0);
                    string col2 = sqlite_datareader.GetInt32(1).ToString();

                    //var x = sqlite_datareader.GetValue(1);
                    Console.WriteLine(col1 + " " + col2);
                }
            }

            
        }

        public void selectMetoda(string input)
        {

            //tableName = "myTable;DELETE FROM TABLE STUDENT;"
            //SQLiteCommand sqlite_cmdSelect = sqlite_conn.CreateCommand();
            //sqlite_cmdSelect.CommandText = "SELECT * FROM " + tableName;

            SQLiteCommand s = sqlite_conn.CreateCommand();
            s.CommandText = "UPDATE players SET name = @name, score = @score, active = @active WHERE jerseyNum = @jerseyNum";

            s.Parameters.Add(new SQLiteParameter("@name", SqlDbType.Text).Value = input);
        }

        public void pridatDoDB(Kniha k)
        {
            //isnert 
        }

        public void pridatDoDB(string jmeno, string autor, string rok)
        {
            //isnert 
        }
    }
}
