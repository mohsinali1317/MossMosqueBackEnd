using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Tables
{
    public class Dates
    {
        public DBConnect DB;

        public Dates()
        {
            DB = new DBConnect();
        }

        public void Insert()
        {
            //open connection
            if (DB.OpenConnection() == true)
            {
                using (var command = DB.GetConnection().CreateCommand())
                {
                    command.CommandText = "INSERT INTO dates (date) VALUES (@1)";
                    command.Parameters.AddWithValue("@1", DateTime.Now.ToString("yyyy-MM-dd"));
                    command.ExecuteNonQuery();
                }
                //close connection
                DB.CloseConnection();
            }
        }
    }
}
