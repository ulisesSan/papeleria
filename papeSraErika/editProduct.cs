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
    public partial class editProduct : Form
    {
        public string barcode;
        public string name;
        public string brand;
        public string description;
        public string price;
        public string stock;
        public editProduct()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "dato recibido" + barcode + name + brand + description + price + stock;
        }
    }
}
