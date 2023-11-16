using System;
using System.Windows.Forms;

namespace papeSraErika
{
    public partial class EditProduct : Form
    {
        public string barcode;
        public string name;
        public string brand1;
        public string desc;
        public string price;
        public string stock;

        public EditProduct(string barCode, string Name, string Brand, string Desc, string Price, string Stock)
        {
            InitializeComponent();
            barcode = barCode;
            name = Name;
            brand1 = Brand;
            desc = Desc;
            price = Price;
            stock = Stock;

            loadData();
        }

        public void loadData()
        {
            textName.Text = name;
            textBrand.Text = brand1;
            textDesc.Text = desc;
            textPrice.Text = price;
            textStock.Text = stock;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string saveName = textName.Text;
            string saveBrand = textBrand.Text;
            string saveDesc = textDesc.Text;
            string savePrice = textPrice.Text;
            string saveStock = textStock.Text;
            savePrice = savePrice.Replace(",", ".");

            string sql = "UPDATE productos set NOMBRE = '" + saveName + "',MARCA = '" + saveBrand + "',DESCRIPCION = '" + saveDesc + "',STOCK = '" + saveStock + "'" +
                ",PRECIO = '" + savePrice + "' where CODIGO_BARRAS = '" + barcode + "';";

            SystemQuerys.principalQuery(sql);
            

            this.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editProduct_Load(object sender, EventArgs e)
        {

        }
    }
}