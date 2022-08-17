using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex10
{
    public partial class Ex10 : Form
    {
        public Ex10()
        {
            InitializeComponent();
        }
        double p, c;
        private void btnPrestacoes_Click(object sender, EventArgs e)
        {
            c = double.Parse(txtPreco.Text);
            p = c / 5;
            txtTotal.Text = c.ToString();
            txtPrestacoes.Text = p.ToString();

        }
    }
}
