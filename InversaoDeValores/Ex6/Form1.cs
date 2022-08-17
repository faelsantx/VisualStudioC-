using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6
{
    public partial class Ex6 : Form
    {
        public Ex6()
        {
            InitializeComponent();
        }
        int a, b, c;
        private void labelB_Click(object sender, EventArgs e)
        {

        }

        private void btnTroca_Click(object sender, EventArgs e)
        {
            a = int.Parse(txtA.Text);
            b= int.Parse(txtB.Text);

            c = a;
            a = b;
            b = c;

            txtTrocaA.Text = a.ToString();
            txtTrocaB.Text = b.ToString();
        }
    }
}
