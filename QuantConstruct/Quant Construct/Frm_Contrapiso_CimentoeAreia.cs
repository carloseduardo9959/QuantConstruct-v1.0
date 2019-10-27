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
    public partial class Frm_Contrapiso_CimentoeAreia : MetroFramework.Forms.MetroForm
    {
        public Frm_Contrapiso_CimentoeAreia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double QtdAreia = double.Parse(txtEspessura.Text) * double.Parse(txtArea.Text) * 1.05 / 100;
            double QtdCimento = (QtdAreia / double.Parse(txtAreia.Text)) * 1400 / 50;
            lblQtdAreia.Text = QtdAreia.ToString("0.0");
            lblQtdCimento.Text = QtdCimento.ToString("0.0");
        }
    }
}