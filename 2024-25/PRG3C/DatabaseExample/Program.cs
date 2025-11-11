using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DatabaseExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SQLiteConnection sqlite_conn = new SQLiteConnection(@"Data Source=L:\Kantori\Kořínek\PRG3C\DatabaseExample\myDatabase.sqlite;");

            sqlite_conn.Open();

            //Command pro práci v DB
            SQLiteCommand sqlite_cmdCreate = sqlite_conn.CreateCommand();
            sqlite_cmdCreate.CommandText = "CREATE TABLE SampleTable(Col1 VARCHAR(20), Col2 INT)";
            sqlite_cmdCreate.ExecuteNonQuery();



            sqlite_conn.Close();
        }
    }
}
