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
    public partial class addProduct : Form
    {
        public addProduct()
        {
            InitializeComponent();
        }

        private void textCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                textCode.ReadOnly = true;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            productMap _product = new productMap();
            _product.BarCode = textCode.Text;
            _product.ProductName = textName.Text;
            _product.Brand1 = textMarca.Text;
            _product.Description1 = textDescription.Text;
            _product.Price1 = textPrecio.Text;
            _product.Stock1 = textStock.Text;

            string insertProduct = "INSERT INTO productos(NOMBRE,MARCA,DESCRIPCION,CODIGO_BARRAS,STOCK,PRECIO)" +
                "values('"+_product.ProductName+"','"+_product.Brand1+"','"+_product.Description1+"','"+_product.BarCode+"','"+_product.Price1+"','"+_product.Stock1+"');";

            systemQuerys.principalQuery(insertProduct);

            DialogResult sino = MessageBox.Show("Desea agregar otro producto","Agregar otro producto",MessageBoxButtons.YesNo);
            if(sino == DialogResult.Yes)
            {
                textCode.Text = "";
                textName.Text = "";
                textMarca.Text = "";
                textDescription.Text = "";
                textPrecio.Text = "";
                textStock.Text = "";
                textCode.ReadOnly = false;
            }
            else
            {
                productView M = new productView();
                M.Refresh();
                this.Close();
            }
        }
    }
}
