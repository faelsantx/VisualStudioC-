using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex9
{
    public partial class Ex9 : Form
    {
        public Ex9()
        {
            InitializeComponent();
        }

        double v, r;
        private void btn1_Click(object sender, EventArgs e)
        {
            v = double.Parse(txtValor.Text);
            r = (v * 70) / 10000;
            txtRendimento.Text = r.ToString();
        }
    }
}
