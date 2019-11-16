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
    public partial class FrmChapisco : MetroFramework.Forms.MetroForm
    {
        public FrmChapisco()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double QtdAreia = double.Parse(txtEspessura.Text) * double.Parse(txtArea.Text) * 1.05 / 1000;
            double QtdCimento = (QtdAreia / double.Parse(txtAreia.Text)) * 1400 / 50;
            lblQtdAreia.Text = QtdAreia.ToString("0.00");
            lblQtdCimento.Text = QtdCimento.ToString("0.0");
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FrmAjuda fa = new FrmAjuda();
            fa.ShowDialog();
        }
    }
}
