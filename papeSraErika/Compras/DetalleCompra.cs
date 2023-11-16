using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace papeSraErika
{
    public partial class DetalleCompra : Form
    {
        public string codigo;
        public DetalleCompra(string _codigo)
        {
            InitializeComponent();
            detalleCompra(_codigo);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void detalleCompra(string data)
        {
            List<object> lista = new List<object>();
            ControladorDesCompras _products = new ControladorDesCompras();
            DataDescVenta.DataSource = _products.descVenta(data);
        }
    }
}
