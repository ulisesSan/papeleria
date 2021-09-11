using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace papeSraErika
{
    public partial class productView : Form
    {

        public productView()
        {
            InitializeComponent();
            Table(null);
        }

        public void Table(string data)
        {
            List<object> lista = new List<object>();
            productController _products = new productController();
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
            addProduct M = new addProduct();
            M.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            editProduct M = new editProduct(barCode,name,brand,desc,price,stock);
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
            string sql = "delete from productos where CODIGO_BARRAS = '" + barcode + "';";

            DialogResult sino = MessageBox.Show("¿Esta seguro de elominar este producto?", "Agregar otro producto", MessageBoxButtons.YesNo);
            if (sino == DialogResult.Yes)
            {
                systemQuerys.principalQuery(sql);
                MessageBox.Show("Producto eliminado con exito");

                Table(null);
            }

        }   

        public void table2()
        {
            Table(null);
        }

        private void productView_Load(object sender, EventArgs e)
        {

        }
    }
}
