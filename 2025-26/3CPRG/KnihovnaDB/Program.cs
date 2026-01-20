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

            SQLiteConnection conn = new SQLiteConnection($"Data Source=C:\\Users\\korinek\\Downloads\\knihovnaDB.db;");
            conn.Open();

            //SELECT * FROM Book;
            SQLiteCommand sqlite_cmdSelect = conn.CreateCommand();
            sqlite_cmdSelect.CommandText = "SELECT * FROM Book";
            //sqlite_cmdSelect.ExecuteNonQuery();
            SQLiteDataReader sqlite_datareader = sqlite_cmdSelect.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                
            }


                conn.Close();

        }
    }
}
