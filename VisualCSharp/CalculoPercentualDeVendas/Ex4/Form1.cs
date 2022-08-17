using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Ex4 : Form
    {
        public Ex4()
        {
            InitializeComponent();
        }
        double salMes;
        double vendas;
        double fixo;
        private void btnCalculo_Click(object sender, EventArgs e)
        {
            fixo = double.Parse(txtSal.Text);
            vendas = double.Parse(txtVendas.Text);
            salMes = vendas * 15 / 100;
            salMes = salMes + fixo;
            txtFinal.Text = salMes.ToString();
        }
    }
}
