using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5
{
    public partial class Ex5 : Form
    {
        public Ex5()
        {
            InitializeComponent();
        }
        double media,n1, n2, n3;

        private void button1_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            n3 = double.Parse(txtN3.Text);
            media = n1 + n2 + n3;
            media = media / 3;
            txtMedia.Text = media.ToString();
        }
    }
}
