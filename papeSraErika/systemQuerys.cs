using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace papeSraErika 
{
    class systemQuerys : dataConection
    {
        public static string principalQuery(string Query)
        {
            string read = null;
            MySqlDataReader reader;
            MySqlConnection connection = dataConection.dataConnect();
            connection.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(Query, connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    read = reader.GetString(0);
                    
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
                read = null;
            }
            return read;
        }

        public static MySqlDataReader dataTable(string Query)
        {
            MySqlDataReader reader;
            MySqlConnection connection = dataConection.dataConnect();
            connection.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(Query, connection);
                reader = command.ExecuteReader();

                return reader;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Message);
                reader = null;
            }

            return reader;
        }
    }
}
