using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
                textBox1.Text = "";
            }
        }
        private void Table(string data)
        {
            int bandera = 0;
            string sql = "select * from productos where CODIGO_BARRAS = '" + data + "'";
            string _list = null;
            MySqlDataReader res = systemQuerys.dataTable(sql);
            while (res.Read())
            {
                string stock = res.GetString(5);
                if(stock == "0")
                {
                    MessageBox.Show("Este producto ya no tiene stock");
                    bandera = 1;

                }
                else
                {
                    _list = res.GetString(4);
                    if(_list.Length != 13)
                    {
                        
                    }
                    _list += " " + res.GetString(1);
                    _list += " " + res.GetString(6);
                    listBox1.Items.Add(_list);
                    bandera = 2;
                }
                
            }
            if(bandera == 0)
            {
                MessageBox.Show("Porducto no encontrado");
            }
        }

        private void dataList()
        {
            string curItem = listBox1.SelectedItem.ToString();
            int data = listBox1.FindString(curItem);
            int numData = listBox1.Items.Count;
            MessageBox.Show(curItem + " " + data+" Numero de datos es"+numData);

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            dataList();
        }
    }
}
