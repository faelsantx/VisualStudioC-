﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex14
{
    public partial class Ex14 : Form
    {
        public Ex14()
        {
            InitializeComponent();
        }
        double n1, n2;
        private void btnMaior_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            if (n1 >= n2)
            {
                txtMaior.Text = n1.ToString();
            }
            else
            {
                txtMaior.Text = n2.ToString();
            }
        }
    }
}
