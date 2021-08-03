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
    public partial class papeShopView : Form
    {
        public papeShopView()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(13))
            {
                string code = textBox1.Text;

                Table(code);
            }  
        }
        private void Table(string data)
        {

            List<object> lista = new List<object>();
            shopController _shop = new shopController();
            shopController lol = new shopController();
            shopTable.DataSource = lol.shopQuery(data);
        }
    }
}
