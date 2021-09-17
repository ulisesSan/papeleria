using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace papeSraErika
{
    class ControladorDescVenta : dataConection
    {
        public List<object> descVenta(string data)
        {
            MySqlDataReader reader;
            List<object> _list = new List<object>();

            if (data == null)
            {
                MessageBox.Show("Algo ha salido mal, contacte al desarrollador");
                return _list;
            }
            else
            {
                string shopQ = "select " +
                    "descripcion_venta.ID_VENTA,productos.NOMBRE,descripcion_venta.CANTIDAD, descripcion_venta.SUBTOTAL " +
                    "from productos,descripcion_venta " +
                    "where ID_VENTA like '" + data + "' and productos.ID_PRODUCTO = ID_PRD;";

                reader = systemQuerys.dataTable(shopQ);

                while (reader.Read())
                {
                    MapaDescVenta _shop = new MapaDescVenta();

                    _shop.Id_venta = reader.GetString(0);
                    _shop.Nombre = reader.GetString(1);
                    _shop.Cantidad = reader.GetString(2);
                    _shop.Subtotal = reader.GetString(3);

                    _list.Add(_shop);
                }

                return _list;
            }
        }
    }
}

