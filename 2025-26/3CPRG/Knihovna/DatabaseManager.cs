using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knihovna
{
    internal class DatabaseManager
    {
        private SQLiteConnection conn;
        private string path = Environment.CurrentDirectory + "\\KnihovnaDB.db";
        public DatabaseManager()
        {
            
            //conn.Open();
            //conn.Close();
        }

        public void insertNewBook(Book k)
        {
            using (conn = new SQLiteConnection($"Data Source={path};"))
            {
                conn.Open();

                SQLiteCommand cmdInsert = conn.CreateCommand();
                cmdInsert.CommandText = $"INSERT INTO Book(Name, Author, Year) VALUES(@name,@author, @year );";
                cmdInsert.Parameters.AddWithValue("@name", k.Name);
                cmdInsert.Parameters.AddWithValue("@author", k.Author);
                cmdInsert.Parameters.AddWithValue("@year", k.Year);
                cmdInsert.ExecuteNonQuery();
            }

        }

        public void updateByID(int id, Book k)
        {
            using (conn = new SQLiteConnection($"Data Source={path};"))
            {
                conn.Open();

                SQLiteCommand cmdUpdate = conn.CreateCommand();
                cmdUpdate.CommandText = $"UPDATE Book SET Name = @name, Author = @author, Year = @year WHERE id = @id";
                cmdUpdate.Parameters.AddWithValue("@name", k.Name);
                cmdUpdate.Parameters.AddWithValue("@author", k.Author);
                cmdUpdate.Parameters.AddWithValue("@year", k.Year);
                cmdUpdate.Parameters.AddWithValue("@id", id);
                cmdUpdate.ExecuteNonQuery();
            }

        }

        public string getAllBooks()
        {
            StringBuilder sb = new StringBuilder();

            using (conn = new SQLiteConnection($"Data Source={path};"))
            {
                conn.Open();
                SQLiteCommand cmdSelect = conn.CreateCommand();
                cmdSelect.CommandText = "SELECT * FROM Book";
                using (SQLiteDataReader dr = cmdSelect.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        //dr.GetInt32(0);
                        sb.Append(dr["Id"].ToString());
                        sb.Append(" ");
                        sb.Append(dr["Name"].ToString());
                        sb.Append(" ");
                        sb.Append(dr["Author"].ToString());
                        sb.Append(" ");
                        sb.AppendLine(dr["Year"].ToString());
                    }
                }
            }

            return sb.ToString();
        }


    }
}
