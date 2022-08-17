using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex18
{
    public partial class Ex18 : Form
    {
        public Ex18()
        {
            InitializeComponent();
        }
        int i;
        private void btnMM_Click(object sender, EventArgs e)
        {
            i = int.Parse(txtIdade.Text);
            if (i >= 18)
            {
                txtMM.Text = "Maior de idade";
            }
            else
            {
                txtMM.Text = "Menor de idade";
            }
        }
    }
}
