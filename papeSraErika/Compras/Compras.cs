using System;
using System.Windows.Forms;


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
            //List<object> lista = new List<object>();
            CompraControlador _ventas = new CompraControlador();
            DataTableVenta.DataSource = _ventas.Venta(Data);
            datoTotal = SystemQuerys.principalQuery("select sum(TOTAL) from ventas where FECHA ='" + fecha + "'");
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
            if(DataTableVenta.Rows.Count != 0)
            {
                DetalleCompra M = new DetalleCompra(DataTableVenta.CurrentRow.Cells[0].Value.ToString());
                M.codigo = DataTableVenta.CurrentRow.Cells[0].ToString();
                M.Show();
            }
            else{
                MessageBox.Show("Aún no hay ventas.");
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SystemQuerys.Copia();
        }
    }
}
