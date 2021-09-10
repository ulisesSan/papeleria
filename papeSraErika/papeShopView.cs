using System;
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
            checkCambio();
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
                    _list += " $ " + res.GetString(6);
                    string Precio = res.GetString(6);
                    float precioSum = float.Parse(lblTotal.Text) + float.Parse(Precio);
                    lblTotal.Text = precioSum.ToString("F2");
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
            selectItem();
            string fecha = DateTime.Now.ToString("yyy-mm-dd");
            int numData = listBox1.Items.Count;
            int id_venta;
            string curItem;
            int id_prod;
            string total = lblTotal.Text;
            MessageBox.Show(fecha);
            /*systemQuerys.principalQuery("insert into ventas(FECHA,TOTAL) values('"+fecha+ "','" + total.Replace(",",".") + "')");

            for (int i = 1; i <= numData; i++)
            {
                try
                {
                    curItem = listBox1.SelectedItem.ToString();
                    
                    string[] codigo = curItem.Split(' ');
                    string last = codigo[codigo.Length-1];
                    id_venta = int.Parse(systemQuerys.principalQuery("select max(id) from ventas"));
                    id_prod = int.Parse(systemQuerys.principalQuery("select ID_PRODUCTO from productos where CODIGO_BARRAS = '" + codigo[0] + "'"));
                    systemQuerys.principalQuery("insert into descripcion_venta(ID_PRD,ID_VENTA,CANTIDAD,SUBTOTAL)" +
                        " values('" + id_prod + "','" + id_venta + "',1,'" + float.Parse(last) + "')");
                    systemQuerys.principalQuery("update productos set STOCK = STOCK - '1' where CODIGO_BARRAS='" + codigo[0] + "'");
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    selectItem();
                    MessageBox.Show("el ultimo elemento es: " + last);
                    lblTotal.Text = "0";
                }
                catch(Exception a) {
                    MessageBox.Show(a.ToString());
                }
            }*/
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

        private void checkCambio()
        {
            lblCambio.Text = "0";
        }

        private void txtCambio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float total = float.Parse(lblTotal.Text);
                float intro = float.Parse(txtCambio.Text);
                float cambio = total - intro;
                lblCambio.Text = cambio.ToString();
            }
            catch {
                lblCambio.Text = "0";
            }
        }
    }
}
