using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace papeSraErika
{
    public partial class ProductView : Form
    {
        public int Inicio = 0;
        public ProductView()
        {
            InitializeComponent();
            Table(null);
            int inicio = Inicio;
            if (inicio != 1)
            {
                CerrarBtn.Show();
                FormBorderStyle = FormBorderStyle.SizableToolWindow;
            }
            else
                CerrarBtn.Hide();

        }

        public void Table(string data)
        {
            List<object> lista = new List<object>();
            ProductController _products = new ProductController();
            productTable.DataSource = _products.Products(data);
        }

        private void Buscar(object sender, EventArgs e)
        {
            string dato = textSearch.Text;

            Table(dato);
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string dato = textSearch.Text;
            Table(dato);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProduct M = new AddProduct();
            M.Show();
        }



        public void button3_Click(object sender, EventArgs e)
        {
            Table(null);
        }

        private void editProduct_Click(object sender, EventArgs e)
        {


            string barCode = productTable.CurrentRow.Cells[0].Value.ToString();
            string name = productTable.CurrentRow.Cells[1].Value.ToString(); 
            string brand = productTable.CurrentRow.Cells[2].Value.ToString();
            string desc = productTable.CurrentRow.Cells[3].Value.ToString();
            string price = productTable.CurrentRow.Cells[4].Value.ToString();
            string stock = productTable.CurrentRow.Cells[5].Value.ToString();
            string data = "3";
            Contrasena M = new Contrasena(data,barCode,name,brand,desc,price,stock);
            M.barcode = barCode;
            M.name = name;
            M.brand1 = brand;
            M.desc = desc;
            M.price = price;
            M.stock = stock;
            M.Show();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string barcode = productTable.CurrentRow.Cells[0].Value.ToString();
            string barCode = null;
            string Brand = null;
            string Name = null;
            string Desc = null;
            string Price = null;
            string Stock = null;

            Contrasena m = new Contrasena(barcode, barCode, Name, Brand, Desc ,Price, Stock);

            m.Show();
        }   

        public void table2()
        {
            Table(null);
        }


        private void addStock_Click(object sender, EventArgs e)
        {
            AddStock m = new AddStock();
            m.Show();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
