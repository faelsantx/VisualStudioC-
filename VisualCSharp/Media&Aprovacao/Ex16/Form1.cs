using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex16
{
    public partial class Ex16 : Form
    {
        public Ex16()
        {
            InitializeComponent();
        }
        double n1 ,n2 , n3, media;
        private void btnMedia_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            n3 = double.Parse(txtN3.Text);
            media = (n1 + n2 + n3) / 3;
            txtMedia.Text = media.ToString();
            if (media >= 7)
            {
                txtCf.Text = "Aprovado";
            }
            if (media <= 5)
            {
                txtCf.Text = "Reprovado";
            }
            if (media > 5 && media < 7) 
            {
                txtCf.Text = "Recuperação";
            }
        }
    }
}
