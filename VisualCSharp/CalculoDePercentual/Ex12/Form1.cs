using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex12
{
    public partial class Ex12 : Form
    {
        public Ex12()
        {
            InitializeComponent();
        }
        double cf, i, d, t;
        private void btnCusto_Click(object sender, EventArgs e)
        {
            cf = double.Parse(txtCf.Text);
            i = (cf * 45) / 100;
            d = (i * 28) / 100;
            t = d + cf;
            txtTotal.Text = t.ToString();
        }
    }
}
