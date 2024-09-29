using System;
using MySql.Data.MySqlClient;

namespace papeSraErika
{
    class DataConection
    {
        public static MySqlConnection dataConnect()
        {
            string stringConection = "Server = localhost; Database = papeleria; Uid = root; Pwd = root";

            try
            {
                MySqlConnection connect = new MySqlConnection(stringConection);
                return connect;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error" + ex.Message);
                return null;
            }
        }
    }
}
