using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DatabazeUvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SQLiteConnection conn = new SQLiteConnection($"Data Source=C:\\Users\\korinek\\Downloads\\test\\database.db;");

            conn.Open();

            SQLiteCommand sqlite_cmdCreate = conn.CreateCommand();
            sqlite_cmdCreate.CommandText = "CREATE TABLE IF NOT EXISTS SampleTable(Col1 VARCHAR(20), Col1 INT)";
            sqlite_cmdCreate.ExecuteNonQuery();

            SQLiteCommand sqlite_cmdSelect = conn.CreateCommand();
            sqlite_cmdSelect.CommandText = "SELECT * FROM SampleTable";
            SQLiteDataReader sqlite_datareader = sqlite_cmdSelect.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                //nebude fungovat - špatný datový typ
                //int hodnota1 = sqlite_datareader.GetInt32(0);

                //vím, že sloupeček 2 je int
                int hodnota2 = sqlite_datareader.GetInt32(1);
                
                //líný programátor - nechá datový typ na systému
                var h = sqlite_datareader.GetValue(1);
                Console.WriteLine($"hodnota 1: {h}, hodnota 2: {hodnota2}");
            }

            //uklízím po sobě nejen datareader
            sqlite_datareader.Close();
            //ale i spojení
            conn.Close();


        }
    }
}
