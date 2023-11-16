using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using papeSraErika.Ventas;

namespace papeSraErika
{
    public partial class papeShopView : Form
    {
        private string Total;
        private string Items;
       
        public papeShopView()
        {
            InitializeComponent();
            checkCambio();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(13))
            {
                AddDataTable addTable = new AddDataTable();
                string resultado = addTable.Table(barCodeText.Text);
                string[] itemsProcesed = resultado.Split(' ');
                if(resultado != "")
                {
                    lblTotal.Text = (float.Parse(lblTotal.Text) + float.Parse(itemsProcesed[itemsProcesed.Length - 1])).ToString();
                    listBox1.Items.Add(resultado);
                }
                barCodeText.Text = "";
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
    }
}
