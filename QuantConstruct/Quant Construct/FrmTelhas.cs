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
    public partial class FrmTelhas : MetroFramework.Forms.MetroForm
    {
        public FrmTelhas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cbTelhas.SelectedIndex == 0) //americana
            {
                double telha = double.Parse(txtArea.Text) * 12.5;
                lblQtdTelhas.Text = telha.ToString("0");
            }

            if (cbTelhas.SelectedIndex == 1) //francesa
            {
                double telha = double.Parse(txtArea.Text) * 16;
                lblQtdTelhas.Text = telha.ToString("0");
            }

            if (cbTelhas.SelectedIndex == 2) //portuguesa
            {
                double telha = double.Parse(txtArea.Text) * 17;
                lblQtdTelhas.Text = telha.ToString("0");
            }

            if (cbTelhas.SelectedIndex == 3) //romana
            {
                double telha = double.Parse(txtArea.Text) * 16;
                lblQtdTelhas.Text = telha.ToString("0");
            }
        }


        private void cbTelhas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTelhas.SelectedIndex == 0) //americana
                pictureBox1.Image = Properties.Resources.americana;


            if (cbTelhas.SelectedIndex == 1) //francesa
                pictureBox1.Image = Properties.Resources.francesa;


            if (cbTelhas.SelectedIndex == 2) //portuguesa
                pictureBox1.Image = Properties.Resources.portuguesa;


            if (cbTelhas.SelectedIndex == 3) //romana
                pictureBox1.Image = Properties.Resources.romana;
        }
    }
}
