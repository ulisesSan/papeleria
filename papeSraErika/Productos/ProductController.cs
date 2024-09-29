using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace papeSraErika
{
    class ProductController : DataConection
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
            reader = SystemQuerys.dataTable(pQuery);

            while (reader.Read())
            {
                ProductMap _productMap = new ProductMap();

                _productMap.BarCode = reader.GetString(4);
                _productMap.ProductName = reader.GetString(1);
                _productMap.Brand = reader.GetString(2);
                _productMap.Description = reader.GetString(3);
                _productMap.Stock = reader.GetInt32(5);
                _productMap.Price = reader.GetString(6);
                _list.Add(_productMap);
            }

            return _list;
        }
    }
}
