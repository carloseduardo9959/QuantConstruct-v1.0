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
    public partial class FrmPiso : MetroFramework.Forms.MetroForm
    {
        public FrmPiso()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //*****CALCULO PISO*****
            double piso = double.Parse(txtComprimento.Text) * double.Parse(txtLargura.Text);
            double perdas = piso * (double.Parse(txtRodape.Text) / 100);
            piso = piso + perdas;
            lblQtdPiso.Text = piso.ToString("0.00");

            //*****CALCULO ARGAMASSA*****
            double argamassa = piso / 3.5;
            lblQtdAgamassa.Text = argamassa.ToString("0");

            //*****CALCULO REJUNTE*****
            double rejunte = piso / 3.5;
            lblQtdRejunte.Text = rejunte.ToString("0");
            pcbxImpressao.Enabled = true;
        }

        private void FrmPiso_Load(object sender, EventArgs e)
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
            float contador = 8;
            float margemSuperior = 35;
            float margemEsquerda = 20;
            float alturaFonte = 0;
            string linha = "";

            Font fonte = new Font("Arial", 16);
            alturaFonte = fonte.GetHeight(ev.Graphics);

            ev.Graphics.DrawImage(Properties.Resources.Capa_Pisos_, 5, -140, 840, 580);

            //Título 
            /*linha = "Pisos e Revestimentos";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);
            contador += 3;*/

            margemSuperior = 30;

            linha = "Calculo de materiais para assentamento de pisos e revestimentos";

            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            linha = "Largura: " + txtLargura.Text.ToString() + " mt(s)";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            linha = "Comprimento: " + txtComprimento.Text.ToString() + " mt(s)";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);
   

            contador++;
            linha = "Porcentagem de Perda: " + txtRodape.Text.ToString() + " %";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            linha = "___________________________________________________________________________________________";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador += 2;
            linha = "Área Total: " + (double.Parse(txtComprimento.Text) * double.Parse(txtLargura.Text)) + " m2";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            linha = "Área com perda: " + ((double.Parse(txtComprimento.Text) * double.Parse(txtLargura.Text)) + (double.Parse(txtComprimento.Text) * double.Parse(txtLargura.Text))* int.Parse(txtRodape.Text)/100) + " m2";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador += 3;
            linha = "Piso: " + lblQtdPiso.Text.ToString() + " m2";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            linha = "Argamassa: " + lblQtdAgamassa.Text.ToString() + " (saco de 20kg)";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            linha = "Rejunte: " + lblQtdRejunte.Text.ToString() + " kg";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

        }
    }
}
