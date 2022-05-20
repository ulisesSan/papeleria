using System;
using System.Windows.Forms;

namespace papeSraErika
{
    public partial class Contrasena : Form
    {
        public string barcode;
        public string name;
        public string brand1;
        public string desc;
        public string price;
        public string stock;
        public string _data;
        public Contrasena(string data, string barCode, string Name, string Brand, string Desc, string Price, string Stock)
        {
            InitializeComponent();
            _data = data;
            barcode = barCode;
            name = Name;
            brand1 = Brand;
            desc = Desc;
            price = Price;
            stock = Stock;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Funcion = 0 ;
            string password = txtPassword.Text;

            if (password == "Momi1960")
            {
                if (_data == null)
                    Funcion = 1;
                else Funcion += int.Parse(_data);

                switch (Funcion)
                {
                    case 1:
                        NuevoUsuario m = new NuevoUsuario();
                        m.Show();
                        this.Close();

                        break;

                    case 2:
                        string sql = "delete from productos where CODIGO_BARRAS = '" + _data + "';";

                        DialogResult sino = MessageBox.Show("¿Esta seguro de eliminar este producto?", "Agregar otro producto", MessageBoxButtons.YesNo);
                        if (sino == DialogResult.Yes)
                        {
                            systemQuerys.principalQuery(sql);
                            MessageBox.Show("Producto eliminado con exito");
                            this.Close();
                        }
                        break;

                    case 3:
                        editProduct M = new editProduct(barcode, name, brand1, desc, price, stock);
                        M.barcode = barcode;
                        M.name = name;
                        M.brand1 = brand1;
                        M.desc = desc;
                        M.price = price;
                        M.stock = stock;
                        M.Show();
                        this.Close();

                        break;
                }
                
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
        }
    }
}
