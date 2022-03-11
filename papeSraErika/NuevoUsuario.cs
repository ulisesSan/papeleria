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
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String password1 = Password1.Text;
            String password2 = Password2.Text;
            if (password1 == password2 && password2 != "" &&password1 != "")
            {
                string sql = "Insert into usuario (nombre, contraseña) values ('"+NameUser.Text+"', '"+password1+"') ";
                Usuarios m = new Usuarios();

                systemQuerys.principalQuery(sql);

                m.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
