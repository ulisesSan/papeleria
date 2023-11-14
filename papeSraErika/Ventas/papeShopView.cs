using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using papeSraErika.Ventas;

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
                //addDataTable addTable = new addDataTable();
                //addTable.Table(textBox1.Text);
                textBox1.Text = "";
            }
        }
        public void Table(string data)
        {
            int bandera = 0;
            string sql = "select * from productos where CODIGO_BARRAS = '" + data + "'";
            string _list = "";
            
            MySqlDataReader res = systemQuerys.dataTable(sql);
            while (res.Read())
            {
                if((res.GetString(5).Equals("0")))
                {
                    MessageBox.Show("Este producto ya no tiene stock");
                    bandera = 1;

                }
                else
                {
                    _list += res.GetString(4) + " " + res.GetString(1) + " $ " + res.GetString(6);
                    setTotalLabel(res.GetString(6));
                    addListBox(_list);
                    listBox1.SetSelected(0,true);
                    bandera = 2;
                }
                
            }
            if(bandera == 0)
            {
                MessageBox.Show("Producto no encontrado");
            }
        }

        private void RealizarCompra(object sender, System.EventArgs e)
        {
            
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("No ha ingresado ningún producto, favor de escanearlo o igresarlo manualmente");
            }
            else
            {
                selectItem();
                string fecha = DateTime.Now.ToString("yyy-MM-dd");
                int numData = listBox1.Items.Count;
                int id_venta;
                string curItem;
                int id_prod;
                float total = float.Parse(lblTotal.Text);
                string vendedor = systemQuerys.principalQuery("select id from usuario where estatus = 1");
                systemQuerys.principalQuery("insert into ventas (FECHA,TOTAL,vendedor) values ('" + fecha + "','" + total + "','"+vendedor+"')");

                for (int i = 1; i <= numData; i++)
                {
                    try
                    {
                        curItem = listBox1.SelectedItem.ToString();
                        string[] codigo = curItem.Split(' ');
                        string last = codigo[codigo.Length - 1];
                        id_venta = int.Parse(systemQuerys.principalQuery("select max(id) from ventas"));
                        id_prod = int.Parse(systemQuerys.principalQuery("select ID_PRODUCTO from productos where CODIGO_BARRAS = '" + codigo[0] + "'"));
                        systemQuerys.principalQuery("insert into descripcion_venta(ID_PRD,ID_VENTA,CANTIDAD,SUBTOTAL)" +
                            " values('" + id_prod + "','" + id_venta + "',1,'" + float.Parse(last) + "')");
                        systemQuerys.principalQuery("update productos set STOCK = STOCK - '1' where CODIGO_BARRAS='" + codigo[0] + "'");
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        selectItem();
                        lblTotal.Text = "0";
                        txtCambio.Text = "";
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.ToString());
                    }
                }
            }
            
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            lblTotal.Text = "0";
            selectItem();
        }

        private void btnCancelAll_Click(object sender, System.EventArgs e)
        {
            int numData = listBox1.Items.Count;
            for(int i = 1; i <= numData; i++)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                selectItem();
                lblTotal.Text = "0";
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

        private void VerProductos_Click(object sender, EventArgs e)
        {
            productView m = new productView();
            m.Show();
            m.Inicio = 1;
        }

        public void setTotalLabel(String data)
        {
            lblTotal.Text = (float.Parse(lblTotal.Text) + float.Parse(data)).ToString();
        }

        public void addListBox(String items)
        {
            listBox1.Items.Add(items);
            listBox1.SetSelected(0, true);
        }
    }
}
