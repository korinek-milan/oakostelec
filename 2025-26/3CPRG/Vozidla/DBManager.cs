using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozidla
{
    internal class DBManager
    {
        SQLiteConnection conn;

        public DBManager()
        {
            string path = Environment.CurrentDirectory;
            string relativePath = "data\\VehiclesDB.db";

            string finalPath = Path.Combine(path, relativePath);

            string connString = $"Data Source={finalPath}";
            conn = new SQLiteConnection(connString);
        }


        public Vehicle getVehicleFromDB(int vehicleID)
        {
            //string kod = $"SELECT * FROM Vehicle WHERE VehicleId = {vehicleID}";

            conn.Open();
            
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Vehicle WHERE VehicleId = @vehicleID";
            cmd.Parameters.AddWithValue("@vehicleID", vehicleID);

            SQLiteDataReader reader = cmd.ExecuteReader();

            //pouze pokud čtu víc řádků, Funkce Read načte jeden další řádek
            //while (reader.Read())
            
            reader.Read();

            //reader.GetInt32(0) -> získám hodnotu ze sloupce na indexu 0

            try
            {
                Vehicle v = new Vehicle(
                    Convert.ToInt32(reader["VehicleId"]),
                    reader["Brand"].ToString(),
                    reader["Model"].ToString(),
                    Convert.ToInt32(reader["Year"]),
                    Convert.ToDouble(reader["PricePerDay"])
                );

                return v;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
        }


    }
}
