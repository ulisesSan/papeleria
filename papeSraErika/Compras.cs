using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace papeSraErika
{
    public partial class Compras : Form
    {
        public float venta_total = 0;
        public Compras()
        {
            InitializeComponent();
            Tabla(null);
            VentaTotal();
        }
        private void Tabla(string Data)
        {
            List<object> lista = new List<object>();
            ventaControlador _ventas = new ventaControlador();
            DataTableVenta.DataSource = _ventas.Venta(Data);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Tabla(null);
            
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            detalleCompra M = new detalleCompra();
            M.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            copia();
        }

       private void copia()
       {
            string constring = "server=localhost;user=root;pwd=root;database=papeleria;";
            string file = "C:\\Users\\Ulises Caceres\\Desktop\\backup.sql";
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                    }
                }
            }
       }

        private void VentaTotal()
        {
            ventaTotal.Text = venta_total.ToString("F2"); 
        }
    }
}
