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
    public partial class Contrasena : Form
    {
        public string _data;
        public Contrasena(string data)
        {
            InitializeComponent();
            _data = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            if (password == "momi1960")
            {
                string sql = "delete from productos where CODIGO_BARRAS = '" + _data + "';";

                DialogResult sino = MessageBox.Show("¿Esta seguro de eliminar este producto?", "Agregar otro producto", MessageBoxButtons.YesNo);
                if (sino == DialogResult.Yes)
                {
                    systemQuerys.principalQuery(sql);
                    MessageBox.Show("Producto eliminado con exito");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
        }
    }
}
