using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }
        double dist;
        double comb;
        double media;
        private void btnMedia_Click(object sender, EventArgs e)
        {
            dist = double.Parse(txtDist.Text);
            comb = double.Parse(txtComb.Text);
            media = dist / comb;
            txtMedia.Text = media.ToString();
        }
    }
}
