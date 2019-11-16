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
    public partial class Frm_tijolos_assentamento : MetroFramework.Forms.MetroForm
    {
        public Frm_tijolos_assentamento()
        {
            InitializeComponent();
        }

        private void Frm_tijolos_assentamento_Load(object sender, EventArgs e)
        {
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroComboBox1.SelectedIndex)
            {
                case 0: //B12/29
                    pictureBox1.Image = Properties.Resources.tijolo_b12291;
                    break;
                case 1: //B15/29
                    pictureBox1.Image = Properties.Resources.tijolo_b15291;
                    break;
                case 2: //B15/39
                    pictureBox1.Image = Properties.Resources.tijolo_b15391;
                    break;
                case 3: //B10/19
                    pictureBox1.Image = Properties.Resources.tijolo_b10191;
                    break;
                case 4: //B10/29
                    pictureBox1.Image = Properties.Resources.tijolo_b10291;
                    break;
                case 5: //B12/14/24
                    pictureBox1.Image = Properties.Resources.tijolo_b1214241;
                    break;
                case 6: //B10/20
                    pictureBox1.Image = Properties.Resources.tijolo_b10201;
                    break;
                case 7: //C5/20
                    pictureBox1.Image = Properties.Resources.tijolo_c5201;
                    break;

            }
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            double areia = 0, tijolo = 0;
            double junta = double.Parse(txtJunta.Text);
            double Area = double.Parse(txtArea.Text);
            switch (metroComboBox1.SelectedIndex)
            {
                case 0: //B12/29
                    areia = junta * 11.5 * ((2 * 19) + 29) * (1.07 / ((19 + 1.5) * (29 + 1.5) / 10000)) * Area / 1000000 * 1.05;
                    tijolo = 1.07 / ((19 + 1.5) * (29 + 1.5) / 10000) * Area; 
                    break;
                case 1: //B15/29
                    areia = junta * 14 * ((2 * 19) + 29) * (1.07 / ((19 + 1.5) * (29 + 1.5) / 10000)) * Area / 1000000 * 1.05;
                    tijolo = 1.07 / ((19 + 1.5) * (29 + 1.5) / 10000) * Area;
                    break;
                case 2: //B15/39
                    areia = junta * 14 * ((2 * 19) + 39) * (1.07 / ((19 + 1.5) * (39 + 1.5) / 10000)) * Area / 1000000 * 1.05;
                    tijolo = 1.07 / ((19 + 1.5) * (39 + 1.5) / 10000) * (double.Parse(txtArea.Text));
                    break;
                case 3: //B10/19
                    areia = junta * 9 * ((2 * 19) + 19) * (1.07 / ((19 + 1.5) * (19 + 1.5) / 10000)) * Area / 1000000 * 1.05;
                    tijolo = 1.07 / ((19 + 1.5) * (19 + 1.5) / 10000) * (double.Parse(txtArea.Text));
                    break;
                case 4: //B10/29
                    areia = junta * 9 * ((2 * 19) + 29) * (1.07 / ((19 + 1.5) * (29 + 1.5) / 10000)) * Area / 1000000 * 1.05;
                    tijolo = 1.07 / ((19 + 1.5) * (29 + 1.5) / 10000) * (double.Parse(txtArea.Text));
                    break;
                case 5: //B12/14/24
                    areia = junta * 11.5 * ((2 * 14) + 24) * (1.07 / ((14 + 1.5) * (24 + 1.5) / 10000)) * Area / 1000000 * 1.05;
                    tijolo = 1.07 / ((14 + 1.5) * (24 + 1.5) / 10000) * (double.Parse(txtArea.Text));
                    break;
                case 6: //B10/20
                    areia = junta * 9 * ((2 * 9) + 19) * (1.07 / ((9 + 1.5) * (19 + 1.5) / 10000)) * Area / 1000000 * 1.05;
                    tijolo = 1.07 / ((9 + 1.5) * (19 + 1.5) / 10000) * (double.Parse(txtArea.Text));
                    break;
                case 7: //C5/20
                    areia = junta * 10 * ((2 * 5) + 20) * (1.07 / ((5 + 1.5) * (20 + 1.5) / 10000)) * Area / 1000000 * 1.05;
                    tijolo = 1.07 / ((5 + 1.5) * (20 + 1.5) / 10000) * (double.Parse(txtArea.Text));
                    break;
            }
            double cim = (areia / double.Parse(txtAreia.Text)) * 1400 / 50;
            double cal = ((areia / (double.Parse(txtAreia.Text))) * ((double.Parse(txtCal.Text)) * 670)) / 20;
            lblCimento.Text = cim.ToString("0.0");
            lblCal.Text = cal.ToString("0.0");
            lblAreia.Text = areia.ToString("0.0");
            lblTijolo.Text = tijolo.ToString("0");
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            lblAreia.Text = "";
            lblCal.Text = "";
            lblCimento.Text = "";
            lblTijolo.Text = "";

            txtArea.Text = "";
            txtAreia.Text = "";
            txtCal.Text = "";
            txtCimento.Text = "";
            txtJunta.Text = "";

        }

     
        private void metroButton1_Click(object sender, EventArgs e)
        {
            FrmAjuda fa = new FrmAjuda();
            fa.ShowDialog();
        }
    }
}
