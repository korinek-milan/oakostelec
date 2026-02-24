using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace KnihovnaDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string workingDirectory = Environment.CurrentDirectory;
            string file = "\\chocolateDB.db";
            string path = workingDirectory + file;
            conn = new SQLiteConnection($"Data Source={path};");*/

            /*
             * SQLiteCommand sqlite_cmdCreate = sqlite_conn.CreateCommand();
                sqlite_cmdCreate.CommandText = "CREATE TABLE IF NOT EXISTS SampleTable(Col1 VARCHAR(20), Col2 INT)";
                sqlite_cmdCreate.ExecuteNonQuery();

                SQLiteCommand sqlite_cmdInsert = sqlite_conn.CreateCommand();
                string input = "test parametru;drop table SampleTable;";
                sqlite_cmdInsert.CommandText = "INSERT INTO SampleTable(Col1, Col2) VALUES($input, 1); ";
                sqlite_cmdInsert.Parameters.AddWithValue("$input", input);
                sqlite_cmdInsert.ExecuteNonQuery();
             */
            /*INSERT INTO SampleTable(Col1, Col2) VALUES($input, 1);
            CREATE TABLE IF NOT EXISTS SampleTable(Col1 VARCHAR(20), Col2 INT)*/

            /*
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
             */
                
            SQLiteConnection conn;
            string workingDirectory = Environment.CurrentDirectory;
            string file = "\\knihovnaDB.db";
            string path = workingDirectory + file;
            conn = new SQLiteConnection($"Data Source={path};");

            //SQLiteConnection conn = new SQLiteConnection($"Data Source=C:\\Users\\korinek\\Downloads\\knihovnaDB.db;");
            conn.Open();

            //zadává uživatel - pozor na SQL Injection
            /*Console.WriteLine("Název knihy:");
            string name = Console.ReadLine();

            Console.WriteLine("Autor:");
            string author = Console.ReadLine();

            Console.WriteLine("Rok:");
            int year = Convert.ToInt32(Console.ReadLine());
            */

            
            /*SQLiteCommand cmdInsert = conn.CreateCommand();
                                                                           //pokud používám parametr, nemusím řešit jednoduché uvozovky u hodnot
            cmdInsert.CommandText = $"INSERT INTO Book (name, author, year) VALUES(@name, @author, @year);";
            
            //vše od uživatele zadávám přes parametry, aby nedošlo k SQL Injection
            cmdInsert.Parameters.AddWithValue("@name", name);
            cmdInsert.Parameters.AddWithValue("@author", author);
            cmdInsert.Parameters.AddWithValue("@year", year);

            //Z databáze nic nechci, proto ExecuteNonQuery();
            cmdInsert.ExecuteNonQuery();*/

            //update se chová úplně stejně jako insert
            //zde jsem se rozhodl napsat hodntoy natvrdo, proto nemusím použít parametry, pokud by zadával uživatel, opět musím parametricky
            SQLiteCommand cmdUpdate = conn.CreateCommand();
            cmdUpdate.CommandText = $"update book set name = 'krasna nova knizka 2', author = 'novy autor' where id = 15;";
            cmdUpdate.ExecuteNonQuery();

            //SELECT * FROM Book;
            /*SQLiteCommand sqlite_cmdSelect = conn.CreateCommand();
            sqlite_cmdSelect.CommandText = "SELECT * FROM Book";
            //sqlite_cmdSelect.ExecuteNonQuery();
            SQLiteDataReader sqlite_datareader = sqlite_cmdSelect.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                try { 
                int id = sqlite_datareader.GetInt32(3);
                string tmp = sqlite_datareader.GetValue(1).ToString();
                string name = sqlite_datareader["name"].ToString();
                Console.WriteLine(id + " " + name);
                }
                catch (Exception ex){ Console.WriteLine("nastala chyba" + ex.Message); }
            }
            sqlite_datareader.Close();*/

            conn.Close();

        }
    }
}
