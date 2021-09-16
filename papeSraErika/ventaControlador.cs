using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace papeSraErika
{
    class ventaControlador : dataConection
    {
         
        public List<object> Venta(string data)
        {
            string fecha = DateTime.Now.ToString("yyy-MM-dd");
            MySqlDataReader reader;
            List<object> _list = new List<object>();
            string pQuery;
            float _total =0;

            if (data == null)
            {
                pQuery = "select * from ventas where FECHA like '%"+fecha+"%'";
            }
            else
            {
                pQuery = "select * from Productos " +
                "where NOMBRE LIKE '%" + data + "%' OR MARCA LIKE '%" + data + "%' OR CODIGO_BARRAS LIKE '%" + data + "%';";
            }
            reader = systemQuerys.dataTable(pQuery);

            while (reader.Read())
            {
                MapCompra _compra = new MapCompra();

                _compra.Id_venta = int.Parse(reader.GetString(0));
                _compra.Fecha_venta = reader.GetString(1);
                _compra.Total = reader.GetString(2);
                _total += float.Parse(reader.GetString(2));
                _list.Add(_compra);
                
            }
            Total(_total);
            return _list;
        }

        public void Total(float _total)
        {
            Compras m = new Compras();
            m.venta_total = _total;
            
        }

    }
    
}
