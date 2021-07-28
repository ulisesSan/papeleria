using System;
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
            float price;
            int stock;
            productMap _product = new productMap();
            _product.BarCode = textCode.Text;
            _product.ProductName = textName.Text;
            _product.Brand1 = textMarca.Text;
            _product.Description1 = textDescription.Text;

            try {
                
                price = float.Parse(textPrecio.Text);
                stock = Int32.Parse(textStock.Text);

                _product.Price1 = price.ToString();
                _product.Stock1 = stock.ToString();

                if(_product.BarCode.Length != 13)
                {
                    MessageBox.Show("Codigo de barras invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string insertProduct = "INSERT INTO productos(NOMBRE,MARCA,DESCRIPCION,CODIGO_BARRAS,STOCK,PRECIO)" +
                "values('" + _product.ProductName + "','" + _product.Brand1 + "','" + _product.Description1 + "','" + _product.BarCode + "','" + _product.Price1 + "','" + _product.Stock1 + "');";
                    systemQuerys.principalQuery(insertProduct);

                    DialogResult sino = MessageBox.Show("Desea agregar otro producto", "Agregar otro producto", MessageBoxButtons.YesNo);
                    if (sino == DialogResult.Yes)
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
                        var form = new productView();
                        form.table2();
                        this.Close();
                    }
                }
                
            } catch(Exception) {
                MessageBox.Show("Debe de ingresar solo numeros en Existencias y Precio");
                textCode.ReadOnly = true;
            }   
        }
    }
}
