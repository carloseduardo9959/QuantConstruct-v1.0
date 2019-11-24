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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImpressao)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pcbxImpressao);
            this.groupBox1.Controls.Add(this.lblQtdRejunte);
            this.groupBox1.Controls.Add(this.metroLabel16);
            this.groupBox1.Controls.Add(this.lblQtdAgamassa);
            this.groupBox1.Controls.Add(this.lblQtdPiso);
            this.groupBox1.Controls.Add(this.metroLabel14);
            this.groupBox1.Controls.Add(this.metroLabel15);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(22, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 114);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado:";
            // 
            // pcbxImpressao
            // 
            this.pcbxImpressao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbxImpressao.Image = ((System.Drawing.Image)(resources.GetObject("pcbxImpressao.Image")));
            this.pcbxImpressao.Location = new System.Drawing.Point(627, 49);
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
            this.lblQtdRejunte.Location = new System.Drawing.Point(172, 69);
            this.lblQtdRejunte.Name = "lblQtdRejunte";
            this.lblQtdRejunte.Size = new System.Drawing.Size(16, 19);
            this.lblQtdRejunte.TabIndex = 2;
            this.lblQtdRejunte.Text = "0";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(14, 69);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(85, 19);
            this.metroLabel16.TabIndex = 1;
            this.metroLabel16.Text = "Rejunte (kg) :";
            // 
            // lblQtdAgamassa
            // 
            this.lblQtdAgamassa.AutoSize = true;
            this.lblQtdAgamassa.Location = new System.Drawing.Point(172, 50);
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
            this.metroLabel14.Location = new System.Drawing.Point(14, 50);
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
            this.metroLabel6.Location = new System.Drawing.Point(23, 60);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(691, 57);
            this.metroLabel6.TabIndex = 23;
            this.metroLabel6.Text = "- Entre com a largura e comprimento de seu cômodo.\r\n- Em porcentagem de perdas, e" +
    "ntre com o percentual de perdas (quebras e recortes).  Normalmente utiliza-se 10" +
    "%.\r\n";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(358, 273);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 30);
            this.btnCalcular.TabIndex = 22;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.txtRodape);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.txtComprimento);
            this.metroPanel1.Controls.Add(this.txtLargura);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 120);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(329, 183);
            this.metroPanel1.TabIndex = 21;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(278, 70);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(41, 19);
            this.metroLabel13.TabIndex = 10;
            this.metroLabel13.Text = "mt(s).";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(278, 108);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(41, 19);
            this.metroLabel12.TabIndex = 9;
            this.metroLabel12.Text = "mt(s).";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(278, 139);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(20, 19);
            this.metroLabel11.TabIndex = 8;
            this.metroLabel11.Text = "%";
            // 
            // txtRodape
            // 
            this.txtRodape.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRodape.Location = new System.Drawing.Point(161, 135);
            this.txtRodape.Name = "txtRodape";
            this.txtRodape.Size = new System.Drawing.Size(111, 23);
            this.txtRodape.TabIndex = 6;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 135);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(152, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Porcentagem de Perdas:";
            // 
            // txtComprimento
            // 
            this.txtComprimento.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtComprimento.Location = new System.Drawing.Point(161, 104);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(111, 23);
            this.txtComprimento.TabIndex = 4;
            // 
            // txtLargura
            // 
            this.txtLargura.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtLargura.Location = new System.Drawing.Point(161, 66);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(111, 23);
            this.txtLargura.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 104);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(152, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Comprimento (metros) :";
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(3, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(323, 41);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Dimensões do cômodo:";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Largura (metros) :";
            // 
            // FrmPiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.metroPanel1);
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
    }
}