using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace papeSraErika
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
            Tabla(null);
        }

        private void Tabla(string Data)
        {
            List<object> lista = new List<object>();
            ventaControlador _ventas = new ventaControlador();
            DataTableVenta.DataSource = _ventas.Venta(Data);
        }
    }
}
