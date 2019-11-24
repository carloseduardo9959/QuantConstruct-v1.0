using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

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
            pcbxImpressao.Enabled = false;
            toolTip1.SetToolTip(pcbxImpressao, "Imprimir relatório");            
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
            pcbxImpressao.Enabled = true;
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

            pcbxImpressao.Enabled = false;
        }

     
        private void metroButton1_Click(object sender, EventArgs e)
        {
            FrmAjuda fa = new FrmAjuda();
            fa.ShowDialog();
        }

        private void pcbxImpressao_Click(object sender, EventArgs e)
        {
            //cria o objeto de impressão
            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Calculo de Materiais para Construção";
            pd.PrintPage += Imprimir;
            //cria objeto preview
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            //associa dois objetos
            ppd.Document = pd;
            ppd.ShowDialog();
        }

        private void Imprimir(object sender, PrintPageEventArgs ev)
        {
            //Configuração das dimenções da página
            float posicaoVertical = 0;
            float contador = 0;
            float margemSuperior = 35;
            float margemEsquerda = 20;
            float alturaFonte = 0;
            string linha = "";

            Font fonte = new Font("Arial", 16);
            alturaFonte = fonte.GetHeight(ev.Graphics);

            //Título 
            linha = "Cálculo de Assentamento de Tijolos";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);
            contador += 3;
            
            margemSuperior = 26;

            switch (metroComboBox1.SelectedIndex)
            {
                case 0: //B12/29
                    linha = "Tijolo - B12/29";
                    break;
                case 1: //B15/29
                    linha = "Tijolo - B15/29";
                    break;
                case 2: //B15/39
                    linha = "Tijolo - B15/39";
                    break;
                case 3: //B10/19
                    linha = "Tijolo Baiano - B10/19";
                    break;
                case 4: //B10/29
                    linha = "Tijolo Baiano - B10/29";
                    break;
                case 5: //B12/14/24
                    linha = "Tijolo Paulista - B12/14/24";
                    break;
                case 6: //B10/20
                    linha = "Tijolo Duplo - B10/20";
                    break;
                case 7: //C5/20
                    linha = "Tijolo Comum - C5/20";
                    break;
            }
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            linha = "Proporção de Cimento: " + txtCimento.Text.ToString();
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            linha = "Proporção de Cal: " + txtCal.Text.ToString();
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            linha = "Proporção de Areia: " + txtAreia.Text.ToString();
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador += 2;
            linha = "Largura da junta: " + txtJunta.Text.ToString() +" cm";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            linha = "Área da parede: " + txtArea.Text.ToString()+" m2";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            linha = "___________________________________________________________________________________________";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador += 2;
            linha = "Quantidade de Cimento: " + lblCimento.Text.ToString() + " (saco de 50kg)";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            linha = "Quantidade de Cal: " + lblCal.Text.ToString() + " (saco de 20kg)";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            linha = "Quantidade de Areia (m3): " + lblAreia.Text.ToString();
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            linha = "Quantidade de tijolos (unidade): " + lblTijolo.Text.ToString();
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);
        }

       
    }
}
