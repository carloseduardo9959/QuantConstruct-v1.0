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
            lblQtdCimento.Text = QtdCimento.ToString("0");
            pcbxImpressao.Enabled = true;
        }

       
        private void Frm_Contrapiso_CimentoeAreia_Load(object sender, EventArgs e)
        {
            pcbxImpressao.Enabled = false;
            toolTip1.SetToolTip(pcbxImpressao, "Imprimir relatório");
        }

        private void cmdAjuda_Click(object sender, EventArgs e)
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
            float contador = 8;
            float margemSuperior = 35;
            float margemEsquerda = 20;
            float alturaFonte = 0;
            string linha = "";

            Font fonte = new Font("Arial", 16);
            alturaFonte = fonte.GetHeight(ev.Graphics);

            ev.Graphics.DrawImage(Properties.Resources.CAPA_CONTRAP, 5, -140, 840, 580);

            //Título 
            /*linha = "Contrapiso de Cimento e Areia";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);
            contador += 3;*/

            margemSuperior = 30;

            linha = "Contrapiso de Cimento e Areia";

            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            linha = "Proporção de Cimento: " + txtCimento.Text.ToString();
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            linha = "Proporção de Areia: " + txtAreia.Text.ToString();
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador += 2;
            linha = "Espessura do Contrapiso: " + txtEspessura.Text.ToString() + " cm";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            linha = "Área da parede: " + txtArea.Text.ToString() + " m2";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            linha = "___________________________________________________________________________________________";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador += 3;
            linha = "Quantidade de Cimento: " + lblQtdCimento.Text.ToString() + " (saco de 50kg)";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;
            linha = "Quantidade de Areia (m3): " + lblQtdAreia.Text.ToString();
            posicaoVertical = margemSuperior + contador * alturaFonte;
            ev.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}

