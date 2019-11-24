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

            pcbxImpressao.Enabled = true;
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

        private void FrmTelhas_Load(object sender, EventArgs e)
        {
            pcbxImpressao.Enabled = false;
            toolTip1.SetToolTip(pcbxImpressao, "Imprimir relatório");
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
            linha = "Cálculo de Telhas";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);
            contador += 3;

            margemSuperior = 26;

            switch (cbTelhas.SelectedIndex)
            {
                case 0: 
                    linha = "Telha Americana";
                    break;
                case 1: 
                    linha = "Telha Francesa";
                    break;
                case 2: 
                    linha = "Telha Portuguesa";
                    break;
                case 3: 
                    linha = "Telha Romana";
                    break;
            }
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);
           
           // ev.Graphics.DrawImage(this.pictureBox1.Image, margemEsquerda, posicaoVertical);


            contador++;
            linha = "Área do telhado: " + txtArea.Text.ToString() + " m2";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            linha = "___________________________________________________________________________________________";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador += 2;
            linha = "Quantidade de Telhas: " + lblQtdTelhas.Text.ToString() + " (un)";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

        }
    }
}
