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
    public partial class productView : Form
    {
        public productView()
        {
            InitializeComponent();
            table(null);
        }

        private void table(string data)
        {
            //List<object> lista = new List<object>();
            productController _products = new productController();
            productTable.DataSource = _products.Products(data);
        }
    }
}
