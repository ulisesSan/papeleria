﻿using System;
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

        private void openForm<secondForm>() where secondForm : Form, new()
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

        private void btnProduct_Click(object sender, EventArgs e)
        {
            openForm<productView>();
        }
    }
}
