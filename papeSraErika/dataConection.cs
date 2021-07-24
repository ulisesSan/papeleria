using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace papeSraErika
{
    class dataConection
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
