using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace papeSraErika
{
    class CompraControlador : DataConection
    {
         
        public List<object> Venta(string data)
        {
            string fecha = DateTime.Now.ToString("yyy-MM-dd");
            MySqlDataReader reader;
            List<object> _list = new List<object>();
            string pQuery;

            if (data == null)
            {
                pQuery = "select ventas.ID, ventas.FECHA,ventas.TOTAL,usuario.nombre from usuario," +
                    "ventas where FECHA like '%"+fecha+"%' AND usuario.id = ventas.VENDEDOR";
            }
            else
            {
                pQuery = "select * from Productos " +
                "where NOMBRE LIKE '%" + data + "%' OR MARCA LIKE '%" + data + "%' OR CODIGO_BARRAS LIKE '%" + data + "%';";
            }
            reader = SystemQuerys.dataTable(pQuery);

            while (reader.Read())
            {
                MapCompra _compra = new MapCompra();

                _compra.Id_venta = int.Parse(reader.GetString(0));
                _compra.Vendedor = reader.GetString(3);
                _compra.Fecha_venta = DateTime.Parse(reader.GetString(1));
                _compra.Total = reader.GetString(2);
                _list.Add(_compra);
                
            }
            return _list;
        }

    }
    
}
