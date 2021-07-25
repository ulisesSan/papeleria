
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace papeSraErika
{
    class productController : dataConection
    {
        public List<object> Products(string data)
        {
            MySqlDataReader reader;
            List<object> _list = new List<object>();
            string pQuery;

            if (data == null)
            {
                pQuery = "select * from Productos";
            }
            else
            {
                pQuery = "select * from Productos " +
                "where NOMBRE LIKE '%" + data + "%' OR MARCA LIKE '%" + data + "%' OR CODIGO_BARRAS LIKE '%" + data + "%';";
            }
            reader = systemQuerys.dataTable(pQuery);

            while (reader.Read())
            {
                productMap _productMap = new productMap();

                _productMap.BarCode = reader.GetString(4);
                _productMap.ProductName = reader.GetString(1);
                _productMap.Brand1 = reader.GetString(2);
                _productMap.Description1 = reader.GetString(3);
                _productMap.Stock1 = reader.GetString(5);
                _productMap.Price1 = reader.GetString(6);
                _list.Add(_productMap);
            }

            return _list;
        }
    }
}
