﻿namespace Quant_Construct
{
    partial class FrmChapisco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChapisco));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnCalcular = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtArea = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.txtEspessura = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtAreia = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtCimento = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcbxImpressao = new System.Windows.Forms.PictureBox();
            this.lblQtdAreia = new MetroFramework.Controls.MetroLabel();
            this.lblQtdCimento = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.metroPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImpressao)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(219, 38);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = " - Espessura de chapisco: 3 a 5 mm.\r\n";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(369, 273);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 30);
            this.btnCalcular.TabIndex = 25;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.txtArea);
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.Controls.Add(this.txtEspessura);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txtAreia);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.txtCimento);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 99);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(330, 204);
            this.metroPanel1.TabIndex = 24;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(257, 131);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(36, 19);
            this.metroLabel9.TabIndex = 24;
            this.metroLabel9.Text = "mm.";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(257, 166);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(31, 19);
            this.metroLabel7.TabIndex = 23;
            this.metroLabel7.Text = "m2.";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(176, 162);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(75, 23);
            this.txtArea.TabIndex = 4;
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(3, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(323, 41);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Dados:";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // txtEspessura
            // 
            this.txtEspessura.Location = new System.Drawing.Point(176, 127);
            this.txtEspessura.Name = "txtEspessura";
            this.txtEspessura.Size = new System.Drawing.Size(75, 23);
            this.txtEspessura.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 57);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(148, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Proporção de Cimento:";
            // 
            // txtAreia
            // 
            this.txtAreia.Location = new System.Drawing.Point(176, 92);
            this.txtAreia.Name = "txtAreia";
            this.txtAreia.Size = new System.Drawing.Size(75, 23);
            this.txtAreia.TabIndex = 2;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 92);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(129, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Proporção de Areia:";
            // 
            // txtCimento
            // 
            this.txtCimento.Location = new System.Drawing.Point(176, 57);
            this.txtCimento.Name = "txtCimento";
            this.txtCimento.Size = new System.Drawing.Size(75, 23);
            this.txtCimento.TabIndex = 1;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(14, 127);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(141, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Espessura de Chapisco";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(14, 162);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(114, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Área do chapisco:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pcbxImpressao);
            this.groupBox1.Controls.Add(this.lblQtdAreia);
            this.groupBox1.Controls.Add(this.lblQtdCimento);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(23, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 114);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado:";
            // 
            // pcbxImpressao
            // 
            this.pcbxImpressao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbxImpressao.Image = ((System.Drawing.Image)(resources.GetObject("pcbxImpressao.Image")));
            this.pcbxImpressao.Location = new System.Drawing.Point(683, 49);
            this.pcbxImpressao.Name = "pcbxImpressao";
            this.pcbxImpressao.Size = new System.Drawing.Size(65, 59);
            this.pcbxImpressao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxImpressao.TabIndex = 30;
            this.pcbxImpressao.TabStop = false;
            this.pcbxImpressao.Click += new System.EventHandler(this.pcbxImpressao_Click);
            // 
            // lblQtdAreia
            // 
            this.lblQtdAreia.AutoSize = true;
            this.lblQtdAreia.Location = new System.Drawing.Point(186, 66);
            this.lblQtdAreia.Name = "lblQtdAreia";
            this.lblQtdAreia.Size = new System.Drawing.Size(16, 19);
            this.lblQtdAreia.TabIndex = 0;
            this.lblQtdAreia.Text = "0";
            // 
            // lblQtdCimento
            // 
            this.lblQtdCimento.AutoSize = true;
            this.lblQtdCimento.Location = new System.Drawing.Point(263, 31);
            this.lblQtdCimento.Name = "lblQtdCimento";
            this.lblQtdCimento.Size = new System.Drawing.Size(16, 19);
            this.lblQtdCimento.TabIndex = 0;
            this.lblQtdCimento.Text = "0";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(14, 66);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(166, 19);
            this.metroLabel8.TabIndex = 0;
            this.metroLabel8.Text = "Quantidade de Areia (m3):";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(14, 31);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(243, 19);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Quantidade de Cimento (saco de 50kg):";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(715, 37);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(62, 23);
            this.metroButton1.TabIndex = 28;
            this.metroButton1.Text = "Ajuda";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // FrmChapisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmChapisco";
            this.Text = "Chapisco";
            this.Load += new System.EventHandler(this.FrmChapisco_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxImpressao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnCalcular;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtArea;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTextBox txtEspessura;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtAreia;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtCimento;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel lblQtdAreia;
        private MetroFramework.Controls.MetroLabel lblQtdCimento;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pcbxImpressao;
    }
}