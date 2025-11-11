using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnihovnaDB
{
    internal class databaseManager
    {
        //atribut connection, který budu později používat
        SQLiteConnection conn;
        
        //string pro connection string
        string connString;

        public databaseManager()
        {
            //vrací cestu ke složce projektu debug nebo release podle toho, co si vybereme při kompilaci projektu
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Složka nebo soubor, který je relativní k projektu
            string relativePath = "data\\knihovna.db"; // Např. "data\mujSoubor.txt" nebo jen "soubor.txt"

            // Kombinace základní cesty a relativní cesty
            string filePath = Path.Combine(baseDirectory, relativePath);

            //pouze ho připravím, budu ho používat později
            connString = $"Data Source={filePath}";

            //tuto variantu nepotřebuji pokud používám using
            //conn = new SQLiteConnection($"Data Source={filePath}");
            //conn = new SQLiteConnection($"Data Source=L:\\Kantori\\Kořínek\\oakostelec-repo\\2025-26\\4CPRG\\KnihovnaDB\\knihovna.db;");
        }    

        public string nactiKnihy()
        {
            //samo to na konci ukončí objekt -> samo to zavolá close()
            using (conn = new SQLiteConnection(connString))
            {
                conn.Open();

                SQLiteCommand cmdSelect = conn.CreateCommand();
                cmdSelect.CommandText = "SELECT * FROM kniha;";

                StringBuilder sb = new StringBuilder();
                using (SQLiteDataReader dr = cmdSelect.ExecuteReader())
                { 
                    while (dr.Read())
                    {
                        //mohu přes název sloupce nebo přes číslo sloupce
                        string nazev = dr["nazev"].ToString();
                        //string nazev = dr.GetString(0);

                        string autor = dr["autor"].ToString(); ;
                        //string autor = dr.GetString(1);

                        //int rok = dr.GetInt32(2);
                        int rok = Convert.ToInt32(dr["rok"]);

                        /*if (rok is null)
                        {
                            rok = "nedefinováno";
                        }*/

                        sb.AppendLine($"název: {nazev}, autor: {autor}, rok: {rok}");
                    }
                    //
                    dr.Close();
                }
                //nemohu vrátit celý string builder, pouze string builder převedu na string a ten poté vracím
                //return sb
                return sb.ToString();
            }
        }

        public void ulozKnihu(Kniha k)
        { 
            conn.Open();
            SQLiteCommand cmdInsert = conn.CreateCommand();
            cmdInsert.CommandText = $"insert into kniha (nazev, autor, rok) VALUES('{k.nazev}','{k.autor}',{k.rokVydani});";

            cmdInsert.ExecuteNonQuery();

            conn.Close();
        }
    }
}
