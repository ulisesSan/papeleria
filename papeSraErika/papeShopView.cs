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
                    string Precio = res.GetString(6);
                    float precioSum = float.Parse(Precio.Replace(",",".")) + float.Parse(lblTotal.Text);
                    lblTotal.Text = precioSum.ToString();
                    listBox1.Items.Add(_list);
                    listBox1.SetSelected(0,true);
                    bandera = 2;
                }
                
            }
            if(bandera == 0)
            {
                MessageBox.Show("Porducto no encontrado");
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            string[] codigo = curItem.Split(' ');
            int numData = listBox1.Items.Count;
            MessageBox.Show(curItem + "  Numero de datos es" + numData + " y lo que recibe de curItem es " + codigo[0] );
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            selectItem();
        }

        private void btnCancelAll_Click(object sender, System.EventArgs e)
        {
            int numData = listBox1.Items.Count;
            for(int i = 1; i <= numData; i++)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                selectItem();
            }
        }

        private void selectItem()
        {
            try
            {
                listBox1.SetSelected(0, true);
            }
            catch
            {

            }
        }
    }
}
