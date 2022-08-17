using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex8
{
    public partial class Ex8 : Form
    {
        public Ex8()
        {
            InitializeComponent();
        }
        double d, q, r;
        private void btnConversao_Click(object sender, EventArgs e)
        {
            d = double.Parse(txtDolar.Text);
            q = double.Parse(txtQtd.Text);
            r = d * q;
            txtReal.Text = r.ToString();
        }
    }
}
