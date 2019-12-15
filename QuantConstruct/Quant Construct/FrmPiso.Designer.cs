namespace Quant_Construct
{
    partial class FrmPiso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPiso));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcbxImpressao = new System.Windows.Forms.PictureBox();
            this.lblQtdRejunte = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.lblQtdAgamassa = new MetroFramework.Controls.MetroLabel();
            this.lblQtdPiso = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnCalcular = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtRodape = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtComprimento = new MetroFramework.Controls.MetroTextBox();
            this.txtLargura = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtLPiso = new MetroFramework.Controls.MetroTextBox();
            this.txtCPiso = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtAPiso = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.txtEspacamento = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImpressao)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblQtdRejunte);
            this.groupBox1.Controls.Add(this.metroLabel16);
            this.groupBox1.Controls.Add(this.lblQtdAgamassa);
            this.groupBox1.Controls.Add(this.lblQtdPiso);
            this.groupBox1.Controls.Add(this.metroLabel14);
            this.groupBox1.Controls.Add(this.metroLabel15);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(23, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 125);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado:";
            // 
            // pcbxImpressao
            // 
            this.pcbxImpressao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbxImpressao.Image = ((System.Drawing.Image)(resources.GetObject("pcbxImpressao.Image")));
            this.pcbxImpressao.Location = new System.Drawing.Point(787, 384);
            this.pcbxImpressao.Name = "pcbxImpressao";
            this.pcbxImpressao.Size = new System.Drawing.Size(65, 59);
            this.pcbxImpressao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxImpressao.TabIndex = 30;
            this.pcbxImpressao.TabStop = false;
            this.pcbxImpressao.Click += new System.EventHandler(this.pcbxImpressao_Click);
            // 
            // lblQtdRejunte
            // 
            this.lblQtdRejunte.AutoSize = true;
            this.lblQtdRejunte.Location = new System.Drawing.Point(172, 89);
            this.lblQtdRejunte.Name = "lblQtdRejunte";
            this.lblQtdRejunte.Size = new System.Drawing.Size(16, 19);
            this.lblQtdRejunte.TabIndex = 2;
            this.lblQtdRejunte.Text = "0";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(14, 89);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(85, 19);
            this.metroLabel16.TabIndex = 1;
            this.metroLabel16.Text = "Rejunte (kg) :";
            // 
            // lblQtdAgamassa
            // 
            this.lblQtdAgamassa.AutoSize = true;
            this.lblQtdAgamassa.Location = new System.Drawing.Point(172, 59);
            this.lblQtdAgamassa.Name = "lblQtdAgamassa";
            this.lblQtdAgamassa.Size = new System.Drawing.Size(16, 19);
            this.lblQtdAgamassa.TabIndex = 0;
            this.lblQtdAgamassa.Text = "0";
            // 
            // lblQtdPiso
            // 
            this.lblQtdPiso.AutoSize = true;
            this.lblQtdPiso.Location = new System.Drawing.Point(172, 31);
            this.lblQtdPiso.Name = "lblQtdPiso";
            this.lblQtdPiso.Size = new System.Drawing.Size(16, 19);
            this.lblQtdPiso.TabIndex = 0;
            this.lblQtdPiso.Text = "0";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(14, 59);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(147, 19);
            this.metroLabel14.TabIndex = 0;
            this.metroLabel14.Text = "Argamassa (saco 20kg):";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(14, 31);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(67, 19);
            this.metroLabel15.TabIndex = 0;
            this.metroLabel15.Text = "Piso (m2):";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 54);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(691, 57);
            this.metroLabel6.TabIndex = 23;
            this.metroLabel6.Text = "- Entre com a largura e comprimento de seu cômodo.\r\n- Em porcentagem de perdas, e" +
    "ntre com o percentual de perdas (quebras e recortes).  Normalmente utiliza-se 10" +
    "%.\r\n";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(747, 298);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 30);
            this.btnCalcular.TabIndex = 22;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroLabel17);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.Controls.Add(this.metroLabel19);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.txtRodape);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.txtEspacamento);
            this.metroPanel1.Controls.Add(this.txtAPiso);
            this.metroPanel1.Controls.Add(this.txtCPiso);
            this.metroPanel1.Controls.Add(this.metroLabel18);
            this.metroPanel1.Controls.Add(this.txtComprimento);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.txtLPiso);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.txtLargura);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 111);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(706, 217);
            this.metroPanel1.TabIndex = 21;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(289, 87);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(41, 19);
            this.metroLabel13.TabIndex = 10;
            this.metroLabel13.Text = "mt(s).";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(289, 116);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(41, 19);
            this.metroLabel12.TabIndex = 9;
            this.metroLabel12.Text = "mt(s).";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(289, 146);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(20, 19);
            this.metroLabel11.TabIndex = 8;
            this.metroLabel11.Text = "%";
            // 
            // txtRodape
            // 
            this.txtRodape.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRodape.Location = new System.Drawing.Point(172, 142);
            this.txtRodape.Name = "txtRodape";
            this.txtRodape.Size = new System.Drawing.Size(111, 23);
            this.txtRodape.TabIndex = 6;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(4, 142);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(152, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Porcentagem de Perdas:";
            // 
            // txtComprimento
            // 
            this.txtComprimento.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtComprimento.Location = new System.Drawing.Point(172, 112);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(111, 23);
            this.txtComprimento.TabIndex = 4;
            // 
            // txtLargura
            // 
            this.txtLargura.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLargura.Location = new System.Drawing.Point(172, 83);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(111, 23);
            this.txtLargura.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 112);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(152, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Comprimento (metros) :";
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(3, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(700, 41);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Dimensões do cômodo:";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Largura (metros) :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(355, 87);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(130, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Largura (Milímetro) :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(355, 116);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(173, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Comprimento (Milímetros) :";
            // 
            // txtLPiso
            // 
            this.txtLPiso.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLPiso.Location = new System.Drawing.Point(543, 83);
            this.txtLPiso.Name = "txtLPiso";
            this.txtLPiso.Size = new System.Drawing.Size(111, 23);
            this.txtLPiso.TabIndex = 3;
            // 
            // txtCPiso
            // 
            this.txtCPiso.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCPiso.Location = new System.Drawing.Point(543, 112);
            this.txtCPiso.Name = "txtCPiso";
            this.txtCPiso.Size = new System.Drawing.Size(111, 23);
            this.txtCPiso.TabIndex = 4;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(660, 83);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(33, 19);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "mm";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(355, 146);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(125, 19);
            this.metroLabel9.TabIndex = 1;
            this.metroLabel9.Text = "Altura (Milímetros) :";
            // 
            // txtAPiso
            // 
            this.txtAPiso.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAPiso.Location = new System.Drawing.Point(543, 142);
            this.txtAPiso.Name = "txtAPiso";
            this.txtAPiso.Size = new System.Drawing.Size(111, 23);
            this.txtAPiso.TabIndex = 4;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(453, 47);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(120, 19);
            this.metroLabel17.TabIndex = 11;
            this.metroLabel17.Text = "Dimensões do Piso";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(4, 175);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(168, 19);
            this.metroLabel18.TabIndex = 1;
            this.metroLabel18.Text = "Espaçamento (Milímetros) :";
            // 
            // txtEspacamento
            // 
            this.txtEspacamento.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEspacamento.Location = new System.Drawing.Point(172, 171);
            this.txtEspacamento.Name = "txtEspacamento";
            this.txtEspacamento.Size = new System.Drawing.Size(111, 23);
            this.txtEspacamento.TabIndex = 4;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(290, 175);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(33, 19);
            this.metroLabel19.TabIndex = 9;
            this.metroLabel19.Text = "mm";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(660, 112);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(33, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "mm";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(660, 142);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(33, 19);
            this.metroLabel10.TabIndex = 10;
            this.metroLabel10.Text = "mm";
            this.metroLabel10.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // FrmPiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 466);
            this.Controls.Add(this.pcbxImpressao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPiso";
            this.Text = "Piso";
            this.Load += new System.EventHandler(this.FrmPiso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImpressao)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel lblQtdRejunte;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel lblQtdAgamassa;
        private MetroFramework.Controls.MetroLabel lblQtdPiso;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton btnCalcular;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtRodape;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtComprimento;
        private MetroFramework.Controls.MetroTextBox txtLargura;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pcbxImpressao;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtAPiso;
        private MetroFramework.Controls.MetroTextBox txtCPiso;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtLPiso;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroTextBox txtEspacamento;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel10;
    }
}