using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex15
{
    public partial class Ex15 : Form
    {
        public Ex15()
        {
            InitializeComponent();
        }
        double n1;
        private void txtN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtN1.Text);
            if (n1 >= 100 && n1 <= 200)
            {
                txtInt.Text = "Está dentro";
            }
            else
            {
                txtInt.Text = "Não está dentro";
            }




            }
        }
    }

