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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPassword.Text;
            string res;
            string update;

            update = "update usuario set estatus = 0";
            systemQuerys.principalQuery(update);

            res = systemQuerys.principalQuery("select * from usuario where NOMBRE = '" + user + "' and contraseña = '" + pass + "'");
            
            if(user == "Erika" && pass == "Momi1960")
            {
                Princial m = new Princial();
                m.Show();
                this.Hide();
            }
            else
            {
                if (res == null)
                {
                    MessageBox.Show("Contraseña o usuarios errones");
                }

                else
                {
                    update = "update usuario set estatus = 1 where nombre = '"+user+"'";
                    systemQuerys.principalQuery(update);
                    Princial m = new Princial();
                    m.Show();
                    this.Hide();
                }
            }
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNUser_Click(object sender, EventArgs e)
        {
            Contrasena m = new Contrasena(null);
            m.Show();
        }
    }
}
