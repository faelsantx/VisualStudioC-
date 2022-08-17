using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex17
{
    public partial class Ex17 : Form
    {
        public Ex17()
        {
            InitializeComponent();
        }
        double n1,inter;
        private void btn_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtN1.Text);

            if (n1 >= 10 && n1 <= 150)
            {
                inter += 1;
                txtTotal.Text = inter.ToString();
            }
            else
            {
                txtN1.Text = "";
                MessageBox.Show("NUMERO FORA DO INTERVALO");
            }

        }
    }
}
