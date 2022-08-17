using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double ac, n2, n1;
        private void btnCalculo_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            n2 = (n1 * n2) / 100;
            ac = n1 + n2;
            txtAc.Text = n2.ToString();
            txtTotal.Text = ac.ToString();
        }
    }
}
