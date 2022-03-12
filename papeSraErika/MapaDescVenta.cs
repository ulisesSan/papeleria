using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papeSraErika
{
    class MapaDescVenta
    {
        private string id_venta;
        private string nombre;
        private string cantidad;
        private string subtotal;

        public string Id_venta { get => id_venta; set => id_venta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
        public string Subtotal { get => subtotal; set => subtotal = value; }
       
    }
}
