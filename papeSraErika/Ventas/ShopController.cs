using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace papeSraErika
{
    class ShopController : DataConection
    {
        public List<object> shopQuery(string data)
        {
            MySqlDataReader reader;
            List<object> _list = new List<object>();

            if(data == null)
            {
                MessageBox.Show("Algo ha salido mal, contacte a l desarrollador");
                return _list;
            }
            else
            {
                string shopQ = "select * from Productos";

                reader = SystemQuerys.dataTable(shopQ);

                while (reader.Read())
                {
                    ShopMap _shop = new ShopMap();

                    _shop.BarCode = reader.GetString(4);
                    _shop.Name = reader.GetString(1);
                    _shop.Price = reader.GetString(6);

                    _list.Add(_shop);
                }

                return _list;
            }
        }
    }
}
