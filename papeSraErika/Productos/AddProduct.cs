﻿using System;
using System.Windows.Forms;

namespace papeSraErika
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void textCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13 || e.KeyChar == (char)12)
            {
                textCode.ReadOnly = true;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string consulta = SystemQuerys.principalQuery("select * from productos where CODIGO_BARRAS = '"+textCode.Text+"'");
            if(consulta == null)
            {
                string price;
                int stock;
                ProductMap _product = new ProductMap();
                _product.BarCode = textCode.Text;
                _product.ProductName = textName.Text;
                _product.Brand = textMarca.Text;
                _product.Description = textDescription.Text;

                try
                {
                    int stock2 = int.Parse(textStock.Text);
                    float price2 = float.Parse(textPrecio.Text);
                    price = textPrecio.Text;
                    stock = Int32.Parse(textStock.Text);
                    _product.Price = price.ToString();
                    _product.Stock = Int32.Parse(stock.ToString());

                    if (_product.BarCode.Length >= 14)
                    {
                        MessageBox.Show("Codigo de barras invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string insertProduct = "INSERT INTO productos(NOMBRE,MARCA,DESCRIPCION,CODIGO_BARRAS,STOCK,PRECIO)" +
                    "values('" + _product.ProductName + "','" + _product.Brand + "','" + _product.Description + "','" + _product.BarCode + "','" + _product.Stock + "','" + _product.Price + "');";
                        SystemQuerys.principalQuery(insertProduct);

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
                            textCode.SelectionStart = 1;
                        }
                        else
                        {
                            ProductView M = new ProductView();
                            var form = new ProductView();
                            form.table2();
                            this.Close();
                        }
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Debe de ingresar solo numeros en Existencias y Precio");
                    textCode.ReadOnly = false;
                    textCode.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Este producto ya existe");
            }
        }
    }
}
