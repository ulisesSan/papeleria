using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace papeSraErika
{
    class shopController : dataConection
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

                reader = systemQuerys.dataTable(shopQ);

                while (reader.Read())
                {
                    shopMap _shop = new shopMap();

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
