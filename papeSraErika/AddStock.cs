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
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Codigo.Text == "" || Stock.Text == "")
            {
                MessageBox.Show("Debe de llenar ambos campos");
            }
            else 
            {
                string _codigo = Codigo.Text;
                string _stock = Stock.Text;

                string sql = "update productos set STOCK = STOCK + " + _stock + " where CODIGO_BARRAS = '" + _codigo + "'";
                systemQuerys.principalQuery(sql);
                DialogResult sino = MessageBox.Show("Desea agregar otro producto", "Agregar otro producto", MessageBoxButtons.YesNo);
                if (sino == DialogResult.Yes)
                {
                    Codigo.Text = "";
                    Stock.Text = "";
                    
                }
                else
                {
                    productView M = new productView();
                    var form = new productView();
                    form.table2();
                    this.Close();
                }
            }
        }

        private void Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 || e.KeyChar == (char)12)
            {
               Codigo.ReadOnly = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
