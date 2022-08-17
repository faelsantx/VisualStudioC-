using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex19
{
    public partial class Ex19 : Form
    {
        public Ex19()
        {
            InitializeComponent();
        }
        string s;
        private void btnExecutar_Click(object sender, EventArgs e)
        {
            s = txtSexo.Text;
            if (s == "F")
            {
                txtRst.Text = "Feminino"; 
            }
            else
            {

            }
            if (s == "M")
            {
                txtRst.Text = "Masculino";
            }
            

        }
    }
}
