using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex20
{
    public partial class Ex20 : Form
    {
        public Ex20()
        {
            InitializeComponent();
        }
        double val, totalG, total;
        int ano;
        
        private void btnExecutar_Click(object sender, EventArgs e)
        {
            ano = int.Parse(txtAno.Text);
            val = double.Parse(txtValor.Text);
            if (ano <= 2000)
            {
                total = total + 1;
                totalG = totalG + 1;
                val = val - (val * 12) / 100;
                txtDesconto.Text = val.ToString();
            }
            else
            {
                val = val - (val * 7) / 100;
                totalG = totalG + 1;
                txtDesconto.Text = val.ToString();
            }
            txtC2.Text = total.ToString();
            txtTotalGeral.Text = totalG.ToString();
        }
    }
}
