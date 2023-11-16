using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace papeSraErika 
{
    class systemQuerys : DataConection
    {
        public static string principalQuery(string Query)
        {
            string read = null;
            MySqlDataReader reader;
            MySqlConnection connection = DataConection.dataConnect();
            connection.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(Query, connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.IsDBNull(0))
                        read = null;
                    else
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
            MySqlConnection connection = DataConection.dataConnect();
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

        public static void Copia()
        {
            string constring = "server=localhost;user=root;pwd=root;database=papeleria;";
            string file = "C:\\Copias\\Backup.sql";
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                    }
                }
            }
        }
    }
}
