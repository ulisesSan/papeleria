using System;
using System.Linq;
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
            openForm<ProductView>();
        }

        public void updateForm()
        {
            openForm<ProductView>();
        }

        private void Venta_Click(object sender, EventArgs e)
        {
            openForm<papeShopView>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openForm<Compras>();
        }

        private void Princial_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelCenter_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
