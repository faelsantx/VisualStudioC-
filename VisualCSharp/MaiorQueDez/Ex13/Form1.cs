﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n1;
        private void btnVer_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(txtN1.Text);
            if (n1 >= 10)
            {
                txtMM.Text = "Maior ou igual";
            }
            else
            {
                txtMM.Text = "Menor";
            }
        }


    }
}
