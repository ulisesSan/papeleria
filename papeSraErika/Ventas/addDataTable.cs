using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace papeSraErika.Ventas
{
    class AddDataTable
    {
        public string Table(string data)
        {
            string sql = "select * from productos where CODIGO_BARRAS = '" + data + "'";
            string _list = "";

            MySqlDataReader res = SystemQuerys.dataTable(sql);
            while (res.Read())
            {
                if (res.GetString(5).Equals(null))
                {
                    MessageBox.Show("Producto no encontrado");
                }
                else
                {
                    if (res.GetString(5).Equals("0"))
                    {
                        MessageBox.Show("Este producto ya no tiene stock");
                    }
                    else
                    {
                        _list = res.GetString(4) + " " + res.GetString(1) + " $ " + res.GetString(6);
                    }
                }
            }
            return _list;
        }
    }
}
