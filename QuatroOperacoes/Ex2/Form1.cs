using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
        }
        double n1;
        double n2;
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            n1 = n1 + n2;
            txtResultado.Text = n1.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            n1 = n1 - n2;
            txtResultado.Text = n1.ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            n1 = n1 / n2;
            txtResultado.Text = n1.ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            n1 = n1 * n2;
            txtResultado.Text = n1.ToString();
        }
    }
}
