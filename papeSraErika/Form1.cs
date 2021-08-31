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
    public partial class Princial : Form
    {
        public Princial()
        {
            InitializeComponent();
        }

        public void openForm<secondForm>() where secondForm : Form, new()
        {
            Form form;
            form = panelCenter.Controls.OfType<secondForm>().FirstOrDefault();

            if (form == null)
            {
                form = new secondForm();
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                panelCenter.Controls.Add(form);
                panelCenter.Tag = form;
                form.Show();
                form.BringToFront();
            }
            else
            {
                form.BringToFront();
            }
        }

        public void btnProduct_Click(object sender, EventArgs e)
        {
            openForm<productView>();
        }

        public void updateForm()
        {
            openForm<productView>();
        }

        private void Venta_Click(object sender, EventArgs e)
        {
            openForm<papeShopView>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openForm<Compras>();
        }
    }
}
