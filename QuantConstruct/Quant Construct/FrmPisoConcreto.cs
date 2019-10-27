﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quant_Construct
{
    public partial class FrmPisoConcreto : MetroFramework.Forms.MetroForm
    {
        public FrmPisoConcreto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double QtdBrita = double.Parse(txtEspessura.Text) * double.Parse(txtArea.Text) * 1.05 / 100 * 0.7;
            double QtdAreia = QtdBrita / double.Parse(txtBrita.Text) * double.Parse(txtAreia.Text);
            double QtdCimento = QtdBrita / double.Parse(txtBrita.Text) * 1400 / 50;
            lblQtdAreia.Text = QtdAreia.ToString("0.00");
            lblQtdBrita.Text = QtdBrita.ToString("0.00");
            lblQtdCimento.Text = QtdCimento.ToString("0");
        }
    }
}