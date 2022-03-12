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
        public Compras()
        {
            InitializeComponent();
            Tabla(null);
        }
        private void Tabla(string Data)
        {
            string datoTotal=null;
            string fecha = DateTime.Now.ToString("yyy-MM-dd");
            List<object> lista = new List<object>();
            ventaControlador _ventas = new ventaControlador();
            DataTableVenta.DataSource = _ventas.Venta(Data);
            datoTotal = systemQuerys.principalQuery("select sum(TOTAL) from ventas where FECHA ='" + fecha + "'");
            if (datoTotal == null)
            {
                ventaTotal.Text = "0";
            }
            else
            {
                ventaTotal.Text = datoTotal;
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Tabla(null);
            
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            detalleCompra M = new detalleCompra(DataTableVenta.CurrentRow.Cells[0].Value.ToString());
            M.codigo = DataTableVenta.CurrentRow.Cells[0].ToString();
            M.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            copia();
        }

       private void copia()
       {
            string constring = "server=localhost;user=root;pwd=root;database=papeleria;";
            string file = "C:\\Copias\\Backup.sql";
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

    }
}
