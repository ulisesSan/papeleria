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
            string update;
            InitializeComponent();
            update = "update usuario set estatus = 0";
            SystemQuerys.principalQuery(update);
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            string update2;
            string user = txtUser.Text;
            string pass = txtPassword.Text;
            string res;

            res = SystemQuerys.principalQuery("select * from usuario where NOMBRE = '" + user + "' and contraseña = '" + pass + "'");
            
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
                    MessageBox.Show("Contraseña o usuarios erroneos");
                }

                else
                {
                    update2 = "update usuario set estatus = 1 where nombre = '"+user+"'";
                    SystemQuerys.principalQuery(update2);
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
            string barcode = null;
            string barCode = null;
            string Brand = null;
            string Name = null;
            string Desc = null;
            string Price = null;
            string Stock = null;

            Contrasena m = new Contrasena(barcode, barCode, Name, Brand, Desc, Price, Stock);
            m.Show();
        }
    }
}
