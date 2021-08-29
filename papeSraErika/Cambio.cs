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
    public partial class Cambio : Form
    {
        string _total = null;
        public Cambio(string total)
        {
            InitializeComponent();
            total = _total;

            Total.Text = total;
        }
    }
}
