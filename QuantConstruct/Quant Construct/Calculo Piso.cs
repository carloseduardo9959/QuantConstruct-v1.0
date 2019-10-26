using System;
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
    public partial class Piso : MetroFramework.Forms.MetroForm
    {
        public Piso()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //*****CALCULO PISO*****
            double piso = double.Parse(txtComprimento.Text) * double.Parse(txtLargura.Text);
            double perdas = piso * (double.Parse(txtRodape.Text) / 100);
            piso = piso + perdas;
            txtResultPiso.Text = piso.ToString("0.00");

            //*****CALCULO ARGAMASSA*****
            double argamassa = piso / 3.5;
            txtResultArgamassa.Text = argamassa.ToString("0");

            //*****CALCULO REJUNTE*****
            double rejunte = piso / 3.5;
            txtResultRejunte.Text = rejunte.ToString("0");

        }
    }
}
